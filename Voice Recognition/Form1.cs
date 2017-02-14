using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Speech.Synthesis;

namespace Voice_Recognition
{
    public partial class Form1 : Form
    {
        SpeechRecognitionEngine recEngine = new SpeechRecognitionEngine();
        SpeechSynthesizer synthesizer = new SpeechSynthesizer();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Choices commands = new Choices();
            commands.Add(new string[]{"hi",
                // numbers segment
                "number one","number two","number three","number four","number five","number six",
                "number seven","number eight","number nine","number zero","number eleven","number twelve","number thirteen",
                "number fourteen","number fifteen","number sixteen","number seventeen","number eighteen","number nineteen","number twenty",
                "number twenty one","number twenty two","number twenty three","number twenty four",
                "number twenty five","number twenty six","number twenty seven","number twenty eight",
                "number twenty nine","number thirty","number thirty one","number thirty two","number thirty three",
                "number thirty four","number thirty five","number thirty six","number thirty seven","number thirty eight",
                "number thirty nine","number fourty","through",
                // atom commands for clearing and exiting
                "atom clear the line","atom end the session","atom delete all","send",
                // atom commands for displaying stucture
                "atom show the sticks","atom show the lines","atom show the cartoon","show the ribbon","atom hide the lines",
                "atom hide the sticks","atom hide the cartoon","atom hide the ribbon",
                "atom enhance residues","atom isolate residues","through",
                "atom color the selection blue","atom color the selection green","atom color the selection purple","atom color the selection red",
                "atom color the selection yellow",
                //fetch commands
                "atom fetch","adom fetch","four oxy bound hemagloben","adom fetch hemagloben"
                });
            GrammarBuilder gBuilder = new GrammarBuilder();
            gBuilder.Append(commands);
            Grammar grammar = new Grammar(gBuilder);

            recEngine.LoadGrammarAsync(grammar);
            recEngine.SetInputToDefaultAudioDevice(); // Check for kinect audio device 
            recEngine.SpeechRecognized += RecEngine_SpeechRecognized;
            
        }

        private void RecEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            switch(e.Result.Text)
            {
                case ("atom clear the line"):
                    SendKeys.Send("^a,{BACKSPACE}");
                    break;
                //case "say hello":
                //    PromptBuilder builder = new PromptBuilder();

                //    builder.StartSentence();
                //    builder.AppendText("Hello Miguel");
                //    builder.EndSentence();

                //    builder.AppendBreak(new TimeSpan(0,0,0,0,1));

                //    builder.StartSentence();
                //    builder.AppendText("how are you", PromptEmphasis.Strong);
                //    builder.EndSentence();
                //    synthesizer.SpeakAsync(builder);
                //    break;
                //case "speak selected text":
                //    synthesizer.SpeakAsync(textBox1.SelectedText);
                //    break;
                case "number zero":
                    SendKeys.Send("0");
                    break;
                case "number one":
                    SendKeys.Send("1");
                    break;
                case "number two":
                    SendKeys.Send("2");
                    break;
                case "number three":
                    SendKeys.Send("3");
                    break;
                case "number four":
                    SendKeys.Send("4");
                    break;
                case "number five":
                    SendKeys.Send("5");
                    break;
                case "number six":
                    SendKeys.Send("6");
                    break;
                case "number seven":
                    SendKeys.Send("7");
                    break;
                case "number eight":
                    SendKeys.Send("8");
                    break;
                case "number nine":
                    SendKeys.Send("9");
                    break;
                case "number ten":
                    SendKeys.Send("10");
                    break;
                case "number eleven":
                    SendKeys.Send("11");
                    break;
                case "number twelve":
                    SendKeys.Send("12");
                    break;
                case "number thirteen":
                    SendKeys.Send("13");
                    break;
                case "number fourteen":
                    SendKeys.Send("14");
                    break;
                case "number fifteen":
                    SendKeys.Send("15");
                    break;
                case "number sixteen":
                    SendKeys.Send("16");
                    break;
                case "number seventeen":
                    SendKeys.Send("17");
                    break;
                case "number eightteen":
                    SendKeys.Send("18");
                    break;
                case "number nineteen":
                    SendKeys.Send("19");
                    break;
                case "number twenty":
                    SendKeys.Send("20");
                    break;
                case "number twenty one":
                    SendKeys.Send("21");
                    break;
                case "number twenty two":
                    SendKeys.Send("22");
                    break;
                case "number twenty three":
                    SendKeys.Send("23");
                    break;
                case "number twenty four":
                    SendKeys.Send("24");
                    break;
                case "number twenty five":
                    SendKeys.Send("25");
                    break;
                case "number twenty six":
                    SendKeys.Send("26");
                    break;
                case "number twenty seven":
                    SendKeys.Send("27");
                    break;
                case "number twenty eight":
                    SendKeys.Send("28");
                    break;
                case "number twenty nine":
                    SendKeys.Send("29");
                    break;
                case "number thirty":
                    SendKeys.Send("30");
                    break;
                case "number thrity one":
                    SendKeys.Send("31");
                    break;
                case "number thirty two":
                    SendKeys.Send("32");
                    break;
                case "number thirty three":
                    SendKeys.Send("33");
                    break;
                case "number thiryt four":
                    SendKeys.Send("34");
                    break;
                case "number thirty five":
                    SendKeys.Send("35");
                    break;
                case "number thirty six":
                    SendKeys.Send("36");
                    break;
                case "number thirty seven":
                    SendKeys.Send("37");
                    break;
                case "number thirty eight":
                    SendKeys.Send("38");
                    break;
                case "number thirty nine":
                    SendKeys.Send("39");
                    break;
                case "number fourty":
                    SendKeys.Send("40");
                    break;
                case "adom fetch four oxy bound hemagloben":
                    SendKeys.Send("fetch 1gzx");
                    SendKeys.Send("{ENTER}");
                    break;
                case "adom fetch hemagloben":
                    SendKeys.Send("fetch 1a3n");
                    SendKeys.Send("{ENTER}");
                    break;
                case "send":
                    SendKeys.Send("{ENTER}");
                    break;
                case "atom hide the lines":
                    SendKeys.Send("hide lines");
                    SendKeys.Send("{ENTER}");
                    break;
                case "atom show the lines":
                    SendKeys.Send("show lines");
                    SendKeys.Send("{ENTER}");
                    break;
                case "atom hide the sticks":
                    SendKeys.Send("hide sticks");
                    SendKeys.Send("{ENTER}");
                    break;
                case "atom show the sticks":
                    SendKeys.Send("show sticks");
                    SendKeys.Send("{ENTER}");
                    break;
                case "atom hide the cartoon":
                    SendKeys.Send("hide cartoon");
                    SendKeys.Send("{ENTER}");
                    break;
                case "atom show the cartoon":
                    SendKeys.Send("show cartoon");
                    SendKeys.Send("{ENTER}");
                    break;
                case "atom hide the ribbon":
                    SendKeys.Send("hide ribbon");
                    SendKeys.Send("{ENTER}");
                    break;
                case "atom show the ribbon":
                    SendKeys.Send("show ribbon");
                    SendKeys.Send("{ENTER}");
                    break;
                case "atom enhance residues":
                    SendKeys.Send("zoom resi ");
                    break;
                case "residues":
                    SendKeys.Send("resi ");
                    break;
                case "through":
                    SendKeys.Send("-");
                    break;
                case "atom isolate residues":
                    SendKeys.Send("select resi ");
                    break;
                case "atom end session":
                    SendKeys.Send("quit ");
                    SendKeys.Send("{ENTER}");
                    break;
                case "atom color the selection purple":
                    SendKeys.Send("color purple, sele");
                    SendKeys.Send("{ENTER}");
                    break;
                case "atom color the selection yellow":
                    SendKeys.Send("color yellow, sele ");
                    SendKeys.Send("{ENTER}");
                    break;
                case "atom color the selection red":
                    SendKeys.Send("color red, sele ");
                    SendKeys.Send("{ENTER}");
                    break;
                case "atom color the selection blue":
                    SendKeys.Send("color blue, sele ");
                    SendKeys.Send("{ENTER}");
                    break;
                case "atom color the selection green":
                    SendKeys.Send("color green, sele ");
                    SendKeys.Send("{ENTER}");
                    break;
                case "selection":
                    SendKeys.Send("sele");
                    SendKeys.Send("{ENTER}");
                    break;
                case "atom delete all":
                    SendKeys.Send("delete all");
                    SendKeys.Send("{ENTER}");
                    break;


            }
        }

        private void btnEnable_Click(object sender, EventArgs e)
        {
            recEngine.RecognizeAsync(RecognizeMode.Multiple);
            btnDisable.Enabled = true;
            btnEnable.Enabled = false;
        }

        private void btnDisable_Click(object sender, EventArgs e)
        {
            recEngine.RecognizeAsyncStop();
            btnDisable.Enabled = false;
            btnEnable.Enabled = true;
        }
    }
}
