using CommunicationLibrary.Email;
using System.Net;
using System.Net.Mail;


string clientUsername = "Enter username here";
string clientPassword = "Enter password here";
var smtpClient = new SmtpClient("smtp.gmail.com")
{
    Port = 587,
    Credentials = new NetworkCredential(clientUsername, clientPassword),
    EnableSsl = true,
};

string senderEmail = "Enter sender email here";
SmtpEmail emailSender = new SmtpEmail(smtpClient, senderEmail, true);

string recieverEmail = "Enter Reciever email here";
emailSender.Send(recieverEmail, "Test Subject", "Test Body");


Console.ReadKey();