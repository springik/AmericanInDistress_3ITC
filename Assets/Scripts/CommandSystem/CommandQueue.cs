using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandQueue
{
    private static CommandQueue instance = new CommandQueue();
    public static CommandQueue Instance => instance;
    private CommandQueue() { queue = new Queue<Command>(); }

    Queue<Command> queue;

    public void AddCommand(Command command)
    {
        queue.Enqueue(command);
    }

    public void ExecuteNextCommand()
    {
        if(queue.Count > 0)
        {
            queue.Dequeue().Execute();
        }
    }

}
