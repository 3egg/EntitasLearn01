using System.Collections.Generic;
using Entitas;

namespace System
{
    /// <summary>
    /// 打印消息系统,相当于service
    /// GameEntity是game底下的实体,可以找到对应的logSystem
    /// 还有对应的InputEntity
    /// </summary>
    public class LogSystem : ReactiveSystem<GameEntity>
    {
        public LogSystem(Contexts context) : base(context.game)//context.game就是gameEntity
        {
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
        {
            throw new NotImplementedException();
        }

        
        /// <summary>
        /// 过滤器代表这个system的执行条件
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        protected override bool Filter(GameEntity entity)
        {
            return entity.hasComponentsLog;
        }

        /// <summary>
        /// 如果filter过滤出来有这个entity就会去执行这个execute
        /// </summary>
        /// <param name="entities"></param>
        /// <exception cref="NotImplementedException"></exception>
        protected override void Execute(List<GameEntity> entities)
        {
            throw new NotImplementedException();
        }
    }
}