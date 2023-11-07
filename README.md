# Communication Library

The **Communication Library** is a C# library that provides a framework for different communication methods, including email and SMS. It defines interfaces and base classes for sending messages using various communication channels. Developers can extend these classes to implement specific communication methods.

## Table of Contents

- [Overview](#overview)
- [Features](#features)
- [Usage](#usage)


## Overview

The Communication Library is organized into namespaces, each focusing on a specific communication method. The primary namespaces are:
- `CommunicationLibrary.Email`: Contains classes and interfaces for email communication.
- `CommunicationLibrary.SMS`: Contains classes and interfaces for SMS communication.

## Features

- Provides a unified interface (`ICommunication`) for sending messages across different communication channels.
- Offers a base class for email communication (`EmailBase`), which can be extended to implement email sending logic.
- Provides a base class for SMS communication (`SMSBase`), which can be extended to implement SMS sending logic.
- Implementes a concrete class for emails that use SMTP (`SmtpEmail`), as an example of possible usecase.

## Usage

To use the Communication Library, you can follow these steps:

1. Add a reference to the library in your C# project.
2. Implement your custom communication classes by extending the provided base classes in the appropriate namespaces (`EmailBase` in `CommunicationLibrary.Email`, or `SMSBase` in `CommunicationLibrary.SMS`).
3. Implement the `Send` method in your custom communication class to handle the sending logic for your specific communication channel.

```csharp
// Example of extending EmailBase
public class CustomEmail : EmailBase
{
    public CustomEmail(SmtpClient smtpClient, string sender, bool isBodyHtml) : base(sender, isBodyHtml)
    {
        // Initialize custom properties
    }

    public override void Send(string recipient, string subject, string message)
    {
        // Implement email sending logic using the provided SMTP client
    }
}

```