using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using OpenAI_API.Chat;
using OpenAI_API.Models;
using OpenAI_API;
//1.setx OPENAI_API_KEY "yourapikey"   (with quotes)
//2.different text editors and rendering systems can show characters differently.
// type out  abcdefghijklmnopqrstuvwxyz ABCDEFGHIJKLMNOPQRSTUVWXYZ 0123456789 and check chars carefully
//3.go to nuget package manager and click the Restore packages button you see in front of you
//4.check to see its installed in both locations
//5.you must close and reopen all currently open processes after using setx command.
// this includes visual studio and the cmd window




namespace Fall2020_CSC403_Project
{

    public class CGPT
    {
        public async Task<string> ReturnCgptResponse(string inputPrompt, int maxTokens)
        {
            OpenAIAPI openAi = new OpenAIAPI(Environment.GetEnvironmentVariable("OPENAI_API_KEY"));
            return (await openAi.Chat.CreateChatCompletionAsync(new ChatRequest
            {
                Model = Model.ChatGPTTurbo,
                Temperature = 0.1,
                MaxTokens = maxTokens,
                Messages = new ChatMessage[1]
                {
                new ChatMessage(ChatMessageRole.User, inputPrompt)
                }
            })).Choices[0].Message.Content;
        }

        public async Task<string> GetBossDecision(int playerHealth, int bossHealth, int playerDamage, int bossDamage, int bossHealAmount)
        {
            string inputPrompt = $"You an enemy in a game. Your opponent (the player) is at {playerHealth} health while you are at {bossHealth} health. The player's attack would remove {playerDamage} health from you, your attack would remove {bossDamage} from the player, and your heal ability increases your health by {bossHealAmount}.  You can either attack or heal. What decision do you choose if your goal is to make the player's health reach 0 without your health reaching 0, but you must attack if {bossHealth} is greater than or equal to the {playerHealth}: attack or heal? Please respond with only the words \"attack\" or \"heal\"";
            int maxTokens = 20;
            var result = await ReturnCgptResponse(inputPrompt, maxTokens); // dont use .Result
            return result.ToString();
        }

        public async Task<string> GetBossIntroStatement()
        {
            string inputPrompt = "You are the final boss of a game. Mr. Peanut has killed all your lackeys, gotten the key, and opened the gate. Wittily, you critically inform Mr. Peanut of his mistake in 30 words or less.";
            int maxTokens = 40;
            var result = await ReturnCgptResponse(inputPrompt, maxTokens); // dont use .Result
            return result.ToString();
        }

        public async Task<string> GetBossMidBattleCommentWinning()
        {
            string inputPrompt = "You are the final boss of a game. You have taken half of Mr. Peanut's health. Say something witty, funny, and communicates your upcoming victory.";
            int maxTokens = 40;
            var result = await ReturnCgptResponse(inputPrompt, maxTokens); // dont use .Result
            return result.ToString();
        }

        public async Task<string> GetBossMidBattleCommentDying()
        {
            string inputPrompt = "You are the final boss of a game. Mr. Peanut has taken half your health. Say something witty, funny, and communicates the end is near in 1 to two short sentences.";
            int maxTokens = 40;
            var result = await ReturnCgptResponse(inputPrompt, maxTokens); // dont use .Result
            return result.ToString();
        }
        
    }
}