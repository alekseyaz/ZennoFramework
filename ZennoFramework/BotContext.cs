using System.Collections.Generic;
using ZennoLab.InterfacesLibrary.ProjectModel;
using Instance = ZennoFramework.Infrastructure.Instance;

namespace ZennoFramework
{
    /// <summary>
    /// Представляет контекст проекта.
    /// </summary>
    public abstract class BotContext
    {
        /// <summary>
        /// Инициализирует новый экземпляр <see cref="BotContext"/>.
        /// </summary>
        /// <param name="instance">Экземпляр инстанса браузера <see cref="ZennoLab.CommandCenter.Instance"/>.</param>
        /// <param name="project">Экземпляр модели проекта <see cref="IZennoPosterProjectModel"/>.</param>
        /// <param name="loggerFactory">Фабрика логеров. Необязательный параметр.</param>
        public BotContext(ZennoLab.CommandCenter.Instance instance, IZennoPosterProjectModel project,
            ILoggerFactory loggerFactory = null)
        {
            Check.NotNull(instance, nameof(instance));
            Project = Check.NotNull(project, nameof(project));

            Configuration = new BotContextConfiguration();
            Interception = new Interception.Interception();

            loggerFactory = loggerFactory ?? new LoggerFactory();
            Configure(loggerFactory);
            Logger = loggerFactory.CreateLogger(GetType().Name);

            Instance = instance.ToExtended(this);
        }

    }
}