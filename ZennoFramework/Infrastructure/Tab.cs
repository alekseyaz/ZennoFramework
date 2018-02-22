using System;
using System.Diagnostics;
using System.Drawing;
using ZennoFramework.Enums;
using ZennoLab.CommandCenter;

namespace ZennoFramework.Infrastructure
{
    /// <summary>
    /// Представляет вкладку браузера. Содержит необходимые методы и свойства для работы с экземпляром вкладки.
    /// </summary>
    public class Tab : ICloneable
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly ZennoLab.CommandCenter.Tab _zennoTab;


        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly BotContext _context;

        /// <summary>
        /// Инициализирует новый экземпляр <see cref="Tab"/>.
        /// </summary>
        /// <param name="tab">Экземпляр <see cref="ZennoLab.CommandCenter.Tab"/>.</param>
        /// <param name="context">Экземпляр контекста <see cref="BotContext"/>.</param>
        public Tab(ZennoLab.CommandCenter.Tab tab, BotContext context)
        {
            _zennoTab = Check.NotNull(tab, nameof(tab));
            _context = Check.NotNull(context, nameof(context));
            _logger = Check.NotNull(context.Logger, nameof(context.Logger));
        }

    }
}