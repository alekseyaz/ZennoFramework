using System;
using System.Diagnostics;
using ZennoFramework.Enums;
using ZennoFramework.Extensions;

namespace ZennoFramework.Infrastructure
{
    /// <summary>
    /// Представляет инстанс браузера. Содержит необходимые методы и свойства для работы с инстансом.
    /// </summary>
    public class Instance : ICloneable
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly ILogger _logger;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly BotContext _context;

        /// <summary>
        /// Инициализирует новый экземпляр <see cref="Instance"/>.
        /// </summary>
        /// <param name="instance">Экземпляр <see cref="ZennoLab.CommandCenter.Instance"/>.</param>
        /// <param name="context">Экземпляр контекста <see cref="BotContext"/>.</param>
        public Instance(ZennoLab.CommandCenter.Instance instance, BotContext context)
        {
            ZennoInstance = Check.NotNull(instance, nameof(instance));
            _context = Check.NotNull(context, nameof(context));
            _logger = Check.NotNull(context.Logger, nameof(context.Logger));
        }

    }
}