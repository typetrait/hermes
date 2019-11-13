using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Windows.Forms;

namespace Hermes
{
    public partial class MainForm : Form
    {
        private IWebDriver driver;
        private Timer timer;

        private Random random;

        private string targetServer;
        private string targetChannel;

        private string[] messages;

        private bool isRunning;

        public MainForm()
        {
            InitializeComponent();

            random = new Random();

            timer = new Timer();
            SetDelay((int)delayField.Value);
            timer.Tick += Timer_Tick;

            //driver = new FirefoxDriver();
            driver = new FirefoxDriver();
            //driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://discordapp.com/");
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (!isRunning)
            {
                Start();
            }
            else
            {
                Stop();
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            try
            {
                currentChannelTextBox.Text = $"{GetCurrentServerName()}@{GetCurrentChannelName()}";

                if (targetServer != GetCurrentServerName() || targetChannel != GetCurrentChannelName())
                {
                    return;
                }

                var discordMessageBox = GetMessageBox();

                discordMessageBox.SendKeys(messages[random.Next(0, messages.Length)]);
                discordMessageBox.SendKeys(OpenQA.Selenium.Keys.Enter);
            }
            catch (NoSuchElementException)
            {
                Stop();
                MessageBox.Show("An element was not found. Have you selected a text channel?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void delayField_ValueChanged(object sender, EventArgs e)
        {
            SetDelay((int)delayField.Value);
        }

        private void Start()
        {
            try
            {
                isRunning = true;

                timer.Start();
                startButton.Text = "Stop";

                messages = messagesTextBox.Lines;

                if (messages.Length < 1)
                {
                    Stop();
                    MessageBox.Show("No messages were set.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                targetServer = GetCurrentServerName();
                targetChannel = GetCurrentChannelName();

                channelTextBox.Text = $"{targetServer}@{targetChannel}";
            }
            catch (NoSuchElementException)
            {
                Stop();
                MessageBox.Show("An element was not found. Have you selected a text channel?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Stop()
        {
            isRunning = false;

            timer.Stop();
            startButton.Text = "Start";
        }

        private IWebElement GetMessageBox()
        {
            return driver.FindElement(By.ClassName("textArea-2Spzkt"));
        }

        private string GetCurrentServerName()
        {
            try
            {
                var currentServerName = driver.FindElement(By.ClassName("name-3YKhmS")).Text;
                return currentServerName;
            }
            catch (NoSuchElementException)
            {
                return string.Empty;
            }
        }

        private string GetCurrentChannelName()
        {
            var currentChannelName = driver.FindElement(By.ClassName("title-29uC1r")).Text;
            return currentChannelName;
        }

        private void SetDelay(int seconds)
        {
            timer.Interval = seconds * 1000;
        }
    }
}