﻿using Microsoft.Bot.Connector;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microsoft.Bot.Builder
{
    public interface IMiddleware { }

    public interface IContextCreated : IMiddleware
    {
        Task ContextCreated(BotContext context);
    }

    public interface IReceiveActivity : IMiddleware
    {
        Task<ReceiveResponse> ReceiveActivity(BotContext context);
    }

    public interface IPostActivity : IMiddleware
    {
        Task PostActivity(BotContext context, IList<Activity> activities);
    }

    public interface IContextDone : IMiddleware
    {
        Task ContextDone(BotContext context);
    }

    public static partial class MiddlewareExtensions
    {
        public static IEnumerable<T> Where<T>(this IList<IMiddleware> middlewares) where T : IMiddleware
        {
            return middlewares.Where(x => x is T).Cast<T>();
        }
    }
}
