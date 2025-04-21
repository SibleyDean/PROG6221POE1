using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poeAssigmentTwo.Structures
{
    public class tipsB
    {
        public List<responseB> GetCybersecurityTips()
        {
            return new List<responseB>
        {
            new responseB
            {
                Triggers = new[] { "passwords", "password", "1" },
                Title = "Password Security Tips",
                Content = "Digital safety still relies heavily on password security. Instead of " +
                         "creating and storing simple or repetitive passwords, use a password " +
                         "manager to create and save complex, one-of-a-kind credentials for every " +
                         "account. Multi-factor authentication (MFA) should be enabled whenever " +
                         "possible to provide an extra layer of protection on top of a simple password.",
                FollowUps = new[] { "security software", "software updates" }
            },
            new responseB
            {
                Triggers = new[] { "security software", "antivirus", "2" },
                Title = "Security Software Tips",
                Content = "High-quality anti-virus and anti-malware software offers crucial defence " +
                         "against online dangers. Choose trustworthy security programs, maintain " +
                         "their updates, and do routine scans. These tools act as a crucial line " +
                         "of defence against malware that could evade other security measures."
            },
            new responseB
            {
                Triggers = new[] { "software updates", "updates", "3" },
                Title = "Keeping Software Updated",
                Content = "One of the most popular places for hackers to enter a system is through " +
                         "outdated software. Turn on automatic updates for your apps, web browsers, " +
                         "and operating system. Because security patches frequently address serious " +
                         "flaws that hackers actively take advantage of, pay close attention to them. " +
                         "For improved security, modern browsers like Chrome and Firefox offer regular, " +
                         "automatic upgrades."
            },
            new responseB
            {
                Triggers = new[] { "phishing", "phishing attempts", "4" },
                Title = "Avoiding Phishing Attempts",
                Content = "Phishing scams have grown more complex and frequently imitate real emails, " +
                         "messages, or phone calls. Any communication that requests personal information, " +
                         "demands quick action, or looks too good to be true should be avoided. Before " +
                         "opening attachments or accessing links, be sure the sender is legitimate, and " +
                         "notify your IT department of any questionable correspondence."
            },
            new responseB
            {
                Triggers = new[] { "browsing", "safe browsing", "5" },
                Title = "Practice Safe Browsing Habits",
                Content = "Use caution when downloading files or accessing websites. Use trustworthy " +
                         "sources, stay away from dubious links or pop-ups, and think about installing " +
                         "security-focused browser extensions. When connecting to unprotected networks, " +
                         "use a VPN to encrypt your internet traffic because public Wi-Fi networks " +
                         "present unique threats."
            }
        };
        }
    }
}
