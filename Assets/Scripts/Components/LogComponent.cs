using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace Components
{
    //数据载体,有一些特性标签
    [Game, Unique] //之前定义好的上下文的类型
    public class LogComponent : IComponent
    {
        /// <summary>
        /// 打印信息
        /// </summary>
        public string message;
    }
}