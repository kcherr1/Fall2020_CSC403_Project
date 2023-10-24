using OpenAI_API;
using System;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private async void InitializeComponent()
        {
            this.maskedTextBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBox1.Location = new System.Drawing.Point(299, 178);
            this.maskedTextBox1.Multiline = true;
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.ReadOnly = true;
            this.maskedTextBox1.Size = new System.Drawing.Size(300, 110);
            this.maskedTextBox1.TabIndex = 0;
            this.maskedTextBox1.TabStop = false;
            // Textbox Text
            //this.maskedTextBox1.Text = "                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                Title: \"Quest for the Enchanted Realms\" - An Epic 2D Side-Scroller Adventure\r\n\r\nIn the heart of an enchanted kingdom, where magic and mystery thrive, a grand adventure unfolds. \"Quest for the Enchanted Realms\" is a mesmerizing 2D side-scrolling game that transports players to a realm of wondrous landscapes, mythical creatures, and epic quests. With its captivating storyline, breathtaking visuals, and immersive gameplay, this game promises to be an unforgettable journey for players of all ages.\r\n\r\nThe Tale Begins\r\n\r\nOur story begins in the picturesque village of Everwood, a place where the ordinary and the extraordinary coexist in harmony. Players step into the shoes of our hero, Aiden, a young and valiant adventurer. His life takes an unexpected turn when he stumbles upon an ancient map that reveals the existence of long-lost enchanted realms. Guided by the whispers of legends and the yearning for adventure, Aiden embarks on a quest that will shape the destiny of the entire kingdom.\r\n\r\nImmersive Gameplay\r\n\r\n\"Quest for the Enchanted Realms\" features classic 2D side-scrolling gameplay that harkens back to the golden age of gaming. Players will navigate Aiden through lush forests, treacherous mountains, and eerie dungeons, all while encountering cunning puzzles, formidable enemies, and hidden treasures. The game's controls are intuitive, making it accessible to both novice players and experienced gamers.\r\n\r\nA Vibrant World\r\n\r\nThe game's hand-drawn artwork brings every corner of the enchanted kingdom to life. From the enchanting beauty of the Elven Glades to the eerie depths of the Shadowed Caverns, each environment is a feast for the eyes. The attention to detail and the vivid colors create a world that feels truly alive. Every frame is a work of art, immersing players in a breathtaking, hand-crafted realm.\r\n\r\nMythical Creatures and Foes\r\n\r\nThroughout Aiden's journey, he will encounter a vast array of mythical creatures, both friend and foe. From the wise and graceful elves to the fiery dragons guarding their hoards, each character is meticulously designed and brings depth to the game's narrative. Players must navigate both diplomacy and combat to progress through the various realms and their unique challenges.\r\n\r\nEpic Quests and Puzzles\r\n\r\nTo unlock the secrets of the enchanted realms, Aiden must complete epic quests that will challenge his wit, strength, and courage. Solve intricate puzzles, decipher ancient runes, and face challenging trials that test your mettle. These quests are not merely about reaching the end but discovering the wisdom hidden in every corner of the game.\r\n\r\nDynamic Multi-Layered Soundtrack\r\n\r\nThe game's enchanting soundtrack adds another layer of immersion to the experience. With a dynamic composition that changes as you progress through different realms, the music reflects the atmosphere, keeping players engaged and enhancing the emotional depth of the story.\r\n\r\nA Hero's Journey\r\n\r\nAs Aiden journeys through the Enchanted Realms, players will witness his growth and transformation from an ordinary adventurer into a true hero. His encounters with the inhabitants of this world and his confrontations with its challenges will shape not only the fate of the kingdom but also his own character.\r\n\r\nCommunity and Collaboration\r\n\r\nIn \"Quest for the Enchanted Realms,\" players will have the opportunity to collaborate, trade, and engage with a thriving community of fellow adventurers. Share tips, strategies, and stories from your journey with other players, forging bonds in a world filled with wonder and peril.\r\n\r\nConclusion\r\n\r\n\"Quest for the Enchanted Realms\" is more than just a game; it is an enchanting odyssey that invites players to embark on a timeless adventure. With its captivating storyline, stunning visuals, and richly immersive gameplay, it is a testament to the enduring appeal of 2D side-scrollers. Get ready to experience the magic, explore the mysteries, and discover the hero within as you set forth on a journey like no other. Dare you step into the Enchanted Realms?";

            // Create the constructor
            CGPT cgpt = new CGPT();
            // Set parameters for call
            string inputPrompt = "Please provide a description of AI.";
            int maxTokens = 20;
            // Request the return of the ReturnCgptResponse method as an asyncronous call (note the async in InitializeComponent and await in this call)
            var result = await cgpt.ReturnCgptResponse(Environment.GetEnvironmentVariable("OPENAI_API_KEY"), inputPrompt, maxTokens); // dont use .Result
            // Format the result and send it to the textbox
            this.maskedTextBox1.Text = "What is AI?: " + result.ToString();

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.maskedTextBox1);
            this.Name = "Form1";
            this.Text = "StoryEntry";

            this.components = new System.ComponentModel.Container();
            this.Timer2scroll = new System.Windows.Forms.Timer(this.components);

            this.Timer2scroll.Enabled = true;
            //this.Timer2scroll.Interval = 10;
            this.Timer2scroll.Tick += new System.EventHandler(this.Timer2scroll_Tick);

            this.ResumeLayout(false);
            this.PerformLayout();




        }



        #endregion

        private System.Windows.Forms.TextBox maskedTextBox1;
        private System.Windows.Forms.Timer Timer2scroll;
    }
}