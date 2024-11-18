using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Delegtes.DelegatesExample
{
    // This class demonstrates the use of events based on delegates in C#.
    internal class EventsExample
    {
        // Delegate definition: 'Notify' is a delegate type that takes a single string parameter.
        // It defines the signature of the methods that can be used with this delegate.
        public delegate void Notify(string message);

        // This class is responsible for publishing events.
        public class EventPublisher
        {
            // Event declaration using the 'Notify' delegate.
            // The event 'OnNotify' can be subscribed to by other classes.
            // By convention, event names start with 'On', indicating that they are associated with an event action.
            public event Notify OnNotify;

            // Method to raise or trigger the event.
            // It takes a message string as an argument and invokes the event if there are any subscribers.
            public void RaiseEvent(string message)
            {
                // Using the null-conditional operator '?.' to safely invoke the event.
                // This ensures that the event is only called if there are subscribers.
                OnNotify?.Invoke(message);
            }
        }

        // This class listens for the event and handles it when it is raised.
        public class EventSubscribers
        {
            // Event handler method that matches the signature of the 'Notify' delegate.
            // This method is called when the 'OnNotify' event is raised.
            public void OnEventRaises(string message)
            {
                // Output the received event message to the console.
                Console.WriteLine("Event received: " + message);
            }
        }

        // Constructor of the 'EventsExample' class, demonstrating the setup of the event system.
        public EventsExample()
        {
            // Create an instance of the event publisher.
            EventPublisher eventPublisher = new EventPublisher();

            // Create an instance of the event subscriber.
            EventSubscribers eventSubscribers = new EventSubscribers();

            // Subscribe the 'OnEventRaises' method of the subscriber to the 'OnNotify' event of the publisher.
            // This means that when 'OnNotify' is triggered, 'OnEventRaises' will be executed.
            eventPublisher.OnNotify += eventSubscribers.OnEventRaises;

            // Trigger the event with a test message.
            // The subscriber's method 'OnEventRaises' will be called, printing the message to the console.
            eventPublisher.RaiseEvent("Test Message");
        }
    }
}

/*
 What is an Event? (based on delegates)
An event let us tell one class when something important happens. It uses a special method called a delegate. 
This means one part of the programm can alert without needing direct connections. 

Why use an Event?
Event allow a class to send updates without knowing who gets them. This makes the system more flexible and organized. 
It helps different parts of the programm work together without being tightly connected. 

Where would we use an Event?
Events are common in logging, monitoring, data changes and button clicks. They are used wherever notifications are needed. 
Any situation where one action triggers other responses can benefit from events. 

 */
