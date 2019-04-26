using System;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Args;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;
using Telegram.Bot.Types.InlineQueryResults;
using Telegram.Bot.Types.InlineKeyboardButtons;
using ApiAiSDK;
using ApiAiSDK.Model; 

namespace TelegramBot
{
    class Program
    {
        static TelegramBotClient Bot;
        static ApiAi apiAi;
        static void Main(string[] args)
        {
            Bot = new TelegramBotClient("661164345:AAEiddqofdtD5Sk9ZM91lqQwJ1Ke8vIBCE0");
            AIConfiguration config = new AIConfiguration("1b11f5031bdf48dfbff0b92d15f8c2b5",SupportedLanguage.Russian);
            apiAi = new ApiAi(config);

            Bot.OnMessage += BotOnMessageReceived;
            Bot.OnCallbackQuery += BotOnCallbackQueryReceived; ;
            var me = Bot.GetMeAsync().Result;

            Console.WriteLine(me.FirstName);

            Bot.StartReceiving();
            Console.ReadLine();
            Bot.StopReceiving();
        }

        private static async void BotOnCallbackQueryReceived(object sender, CallbackQueryEventArgs e)
        {
            string buttonText = e.CallbackQuery.Data;
            string name = $"{e.CallbackQuery.From.FirstName} {e.CallbackQuery.From.LastName}";
            Console.WriteLine($"{name} нажал кнопку {buttonText}");

            await Bot.AnswerCallbackQueryAsync(e.CallbackQuery.Id, $"слово {buttonText}");
        }

        private static async void BotOnMessageReceived(object sender, Telegram.Bot.Args.MessageEventArgs e)
        {
            var message = e.Message;
            if (message == null || message.Type != MessageType.TextMessage)
                 return;
            string name = $"{message.From.FirstName} {message.From.LastName}";
            Console.WriteLine($"{name} /tотправил сообщение: '{message.Text}'");
            switch (message.Text)
            {
                case "/start":
                    string text =
@"Список команд:
/start запуск бота
/inline вывод меню
/keyboard вывод клавиатуры";
                    await Bot.SendTextMessageAsync(message.From.Id, text);
                    break;
                case "/inline":
                    var inlineKeyboard = new InlineKeyboardMarkup(new[]
                    {
                        new[]
                        {
                            InlineKeyboardPayButton.WithUrl("VK", "https://vk.com/"),
                            InlineKeyboardPayButton.WithUrl("Telegram", "https://t.me/weegi")
                        },
                        new[]
                        {
                            InlineKeyboardPayButton.WithCallbackData("Саша жопа"),
                            InlineKeyboardPayButton.WithCallbackData("Или писька")
                        }
                    });
                    await Bot.SendTextMessageAsync(message.From.Id, "Выберите пункт меню",
                        replyMarkup: inlineKeyboard);
                    break;
                case "/keyboard":
                    var replyKeyboard = new ReplyKeyboardMarkup(new[]
                    {
                        new[]
                        {
                            new KeyboardButton("Привет"),
                            new KeyboardButton("Как дела?")
                        },
                        new[]
                        {
                            new KeyboardButton("Ваш номер телефона") { RequestContact = true },
                            new KeyboardButton("Ваша геолокация") { RequestLocation = true }
                        }
                    });
                    await Bot.SendTextMessageAsync(message.Chat.Id, "Ваш запрос отправлен",
                        replyMarkup: replyKeyboard);
                    break;
                default:
                    var response = apiAi.TextRequest(message.Text);
                    string answer = response.Result.Fulfillment.Speech;
                    if (answer == "")
                        answer = "Я хочу чтобы мне сделали)";
                    await Bot.SendTextMessageAsync(message.From.Id, answer);
                    break;
            }
        }
    }
}
