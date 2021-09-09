﻿using Clean_Architecture.Domain.Common;
using Clean_Architecture.Domain.Entities;

namespace Clean_Architecture.Domain.Events
{
    public class TodoItemCompletedEvent : DomainEvent
    {
        public TodoItemCompletedEvent(TodoItem item)
        {
            Item = item;
        }

        public TodoItem Item { get; }
    }
}
