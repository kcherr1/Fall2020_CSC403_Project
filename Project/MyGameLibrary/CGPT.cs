using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// -- OpenAI Package installation --
// 1. Tools> NuGet Package Manager>NuGet Console
// 2. command: "Install-Package OpenAI"
// 3. Tools> NuGet Package Manager> Manage NuGet Packages for Solution
// 4. Look for OpenAI Api and on the right window, click install into the solution's relevant folders
// 5. Confirm and accept eveyrthing

// -- API KEY BEST PRACTICE --
// IN WINDOWS
// - Store api key as environment variable and call that environment variable from the program
//     use command: "setx OPENAI_API_KEY “<yourkey>” to store api key as OPEN_API_KEY env variable.
// IN LINUX
// 1. Store api key as env variable similar to above
//   use command: 'echo "export OPENAI_API_KEY='yourkey'" >> ~/.zshrc' without the single quotes
//   to store api key as env variable.
// 2. use command: "source ~/.zshrc" to update the shell with new variable
// 3. Confirm env variable: "echo $OPENAI_API_KEY"


using OpenAI_API;
using OpenAI_API.Chat;
using OpenAI_API.Completions;
using OpenAI_API.Models;
using OpenAI_API.Moderation;


namespace Fall2020_CSC403_Project
{
    /*
    public class TextBoxer : Form
    {
        
        public TextBox textBox1;
        public TextBoxer()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.AcceptsTab = true;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Multiline = true;
            //this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.textBox1);
            this.Text = "this isnt text";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }*/
        

    public class CGPT
    {   
        public async Task<string> ReturnCgptResponse(string apikey, string inputPrompt, int maxTokens)
        {
            // Setup api handle
            var openAi = new OpenAIAPI(apikey);

            // Construct the result with desired parameters
            var result = await openAi.Chat.CreateChatCompletionAsync(new ChatRequest()
            {
                Model = Model.ChatGPTTurbo,
                Temperature = 0.1,
                MaxTokens = maxTokens,
                Messages = new ChatMessage[] 
                {
                    new ChatMessage(ChatMessageRole.User, inputPrompt)
                }
            });

            // Return the string result
            return result.Choices[0].Message.Content;
            
        }

        public string GetBossDecisionCGPT(int playerHealth, int bossHealth, int playerAttackDamage, int bossAttackDamage, int bossHealAmount)
        {
            // 88 input tokens + 1 output token
            string inputPrompt = $"you are the final boss in a game, your opponent (the player), is at {playerHealth} health and he has just attacked you for {playerAttackDamage} damage leaving you with {bossHealth} of your original 20 health. You can either choose to attack or heal. Your attack damage will remove {bossAttackDamage} health from the player and your heal with return {bossHealAmount} health points. What decision do you choose if your goal is to make the player's health reach 0: attack or heal? Please respond with only the words \"attack\" or \"heal\"";
            var result = ReturnCgptResponse(Environment.GetEnvironmentVariable("OPENAI_API_KEY"), inputPrompt, 20);
            return result.ToString();
        }

        public string GetBossIntroStatement()
        {
            string inputPrompt = "You are the boss in the game,a whicked AI chatbot who wants to destroy all peanuts. Proclaim your victory to the player by words in advance by saying something witty! Tailor the response to a player of about college age and keep it wihtout offensive or adult content.";
            var result = ReturnCgptResponse(Environment.GetEnvironmentVariable("OPENAI_API_KEY"), inputPrompt, 20);
            return result.ToString();
        }

        public string GetBossMidBattleStatement()
        {
            string inputPrompt = "You are the boss in the game,a whicked AI chatbot who wants to destroy all peanuts. You have been in a heated fight with the peanut man (player) for some time. Make a witty and/or funny statement in the midst of battle to keep the excitement level high!";
            var result = ReturnCgptResponse(Environment.GetEnvironmentVariable("OPENAI_API_KEY"), inputPrompt, 20);
            return result.ToString();
        }
    }
}

