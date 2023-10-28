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

namespace Fall2020_CSC403_Project
{

    public class CGPT
    {
        public async Task<string> ReturnCgptResponse(string apikey, string inputPrompt, int maxTokens)
        {
            OpenAIAPI openAi = new OpenAIAPI(apikey);
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
            var result = await ReturnCgptResponse(Environment.GetEnvironmentVariable("OPENAI_API_KEY"), inputPrompt, maxTokens); // dont use .Result
            return result.ToString();
        }

        public async Task<string> GetBossIntroStatement()
        {
            string inputPrompt = "You are the final boss of a game. Mr. Peanut has gotten the key, opened the gate, and destroyed your lackeys. Wittily inform Mr. Peanut of the critical mistake he has made in 30 words of less.";
            int maxTokens = 40;
            var result = await ReturnCgptResponse(Environment.GetEnvironmentVariable("OPENAI_API_KEY"), inputPrompt, maxTokens); // dont use .Result
            return result.ToString();
        }

        public async Task<string> GetBossMidBattleCommentWinning()
        {
            string inputPrompt = "You are the final boss of a game. You have taken half of Mr. Peanut's health. Say something witty, funny, and communicates your upcoming victory.";
            int maxTokens = 40;
            var result = await ReturnCgptResponse(Environment.GetEnvironmentVariable("OPENAI_API_KEY"), inputPrompt, maxTokens); // dont use .Result
            return result.ToString();
        }

        public async Task<string> GetBossMidBattleCommentDying()
        {
            string inputPrompt = "You are the final boss of a game. Mr. Peanut has taken half your health. Say something witty, funny, and communicates the end is near in 1 to two short sentences.";
            int maxTokens = 40;
            var result = await ReturnCgptResponse(Environment.GetEnvironmentVariable("OPENAI_API_KEY"), inputPrompt, maxTokens); // dont use .Result
            return result.ToString();
        }
        
    }
}