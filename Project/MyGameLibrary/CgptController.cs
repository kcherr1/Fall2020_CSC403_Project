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
            // TODO: Make inputPrompt
            string inputPrompt = "";
            int maxTokens = 20;
            var result = await ReturnCgptResponse(Environment.GetEnvironmentVariable("OPENAI_API_KEY"), inputPrompt, maxTokens); // dont use .Result
            return result.ToString();
        }

        public async Task<string> GetBossMidBattleCommentWinning()
        {
            // TODO: Make inputPrompt
            string inputPrompt = "You are the final boss of a game. You have taken half of Mr. Peanut's health. Say something witty, funny, and communicates your upcoming victory.";
            int maxTokens = 40;
            var result = await ReturnCgptResponse(Environment.GetEnvironmentVariable("OPENAI_API_KEY"), inputPrompt, maxTokens); // dont use .Result
            return result.ToString();
        }

        public async Task<string> GetBossMidBattleCommentDying()
        {
            // TODO: Make inputPrompt
            string inputPrompt = "You are the final boss of a game. Mr. Peanut has taken half your health. Say something witty, funny, and communicates the end is near in 1 to two short sentences.";
            int maxTokens = 40;
            var result = await ReturnCgptResponse(Environment.GetEnvironmentVariable("OPENAI_API_KEY"), inputPrompt, maxTokens); // dont use .Result
            return result.ToString();
        }
        
    }
}

// TODO:
/*
 * 1. clean up commented code
 * 2. extend the size of "label3" so that all of CGPT's text fits the screen
 * 3. Make battle sound effects for when attack/heal happens.. a xing sound when both attack etc.
 * 4. update my spreadsheet with the user story to reflect what I actually did and features I added.
 *  one feature per branch, etc.
 * 5. commit, push, and sync everything to the repo BUT MAKE SURE YOU HAVE A LOCAL COPY OF THE FILES.
 *   THE FILES GET WIPED AND REMOVED AUTOMATICALLY WHENEVER YOU CHANGE SOMETHING HERE. DO NOT EXPECT
 *   LOCAL FILES WILL BE UNTOUCHED IF YOU MESS WITH FILES HERE!
 */

