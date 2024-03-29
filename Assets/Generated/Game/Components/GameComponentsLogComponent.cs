//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameContext {

    public GameEntity componentsLogEntity { get { return GetGroup(GameMatcher.ComponentsLog).GetSingleEntity(); } }
    public Components.LogComponent componentsLog { get { return componentsLogEntity.componentsLog; } }
    public bool hasComponentsLog { get { return componentsLogEntity != null; } }

    public GameEntity SetComponentsLog(string newMessage) {
        if (hasComponentsLog) {
            throw new Entitas.EntitasException("Could not set ComponentsLog!\n" + this + " already has an entity with Components.LogComponent!",
                "You should check if the context already has a componentsLogEntity before setting it or use context.ReplaceComponentsLog().");
        }
        var entity = CreateEntity();
        entity.AddComponentsLog(newMessage);
        return entity;
    }

    public void ReplaceComponentsLog(string newMessage) {
        var entity = componentsLogEntity;
        if (entity == null) {
            entity = SetComponentsLog(newMessage);
        } else {
            entity.ReplaceComponentsLog(newMessage);
        }
    }

    public void RemoveComponentsLog() {
        componentsLogEntity.Destroy();
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Components.LogComponent componentsLog { get { return (Components.LogComponent)GetComponent(GameComponentsLookup.ComponentsLog); } }
    public bool hasComponentsLog { get { return HasComponent(GameComponentsLookup.ComponentsLog); } }

    public void AddComponentsLog(string newMessage) {
        var index = GameComponentsLookup.ComponentsLog;
        var component = (Components.LogComponent)CreateComponent(index, typeof(Components.LogComponent));
        component.message = newMessage;
        AddComponent(index, component);
    }

    public void ReplaceComponentsLog(string newMessage) {
        var index = GameComponentsLookup.ComponentsLog;
        var component = (Components.LogComponent)CreateComponent(index, typeof(Components.LogComponent));
        component.message = newMessage;
        ReplaceComponent(index, component);
    }

    public void RemoveComponentsLog() {
        RemoveComponent(GameComponentsLookup.ComponentsLog);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherComponentsLog;

    public static Entitas.IMatcher<GameEntity> ComponentsLog {
        get {
            if (_matcherComponentsLog == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.ComponentsLog);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherComponentsLog = matcher;
            }

            return _matcherComponentsLog;
        }
    }
}
