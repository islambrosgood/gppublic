using Robust.Shared.GameStates;
using Robust.Shared.Serialization;

namespace Content.Shared.Clothing.Components;

[RegisterComponent]
[NetworkedComponent]
public sealed partial class HelmetOverlayComponent : Component
{
    [ViewVariables(VVAccess.ReadOnly)] public EntityUid? Equipee;

    [DataField("gravitySensor")] [ViewVariables(VVAccess.ReadWrite)]
    public bool GravitySensor;

    [ViewVariables(VVAccess.ReadOnly)] public bool? HasGravity;

    /// <summary>
    ///     Draws a shader and sensor readings if true.
    /// </summary>
    [DataField("hasHud")] [ViewVariables(VVAccess.ReadWrite)]
    public bool HasHud;

    [ViewVariables(VVAccess.ReadOnly)] public float? Health;

    [DataField("healthSensor")] [ViewVariables(VVAccess.ReadWrite)]
    public bool HealthSensor;

    [ViewVariables(VVAccess.ReadOnly)] public float? InternalsPressure;

    [DataField("internalsSensor")] [ViewVariables(VVAccess.ReadWrite)]
    public bool InternalsSensor;

    [ViewVariables(VVAccess.ReadOnly)] public float? Pressure;

    [DataField("pressureSensor")] [ViewVariables(VVAccess.ReadWrite)]
    public bool PressureSensor;

    [ViewVariables(VVAccess.ReadOnly)] public float? Radiation;

    [DataField("radiationSensor")] [ViewVariables(VVAccess.ReadWrite)]
    public bool RadiationSensor;

    [DataField("texture")] [ViewVariables(VVAccess.ReadWrite)]
    public string? Texture;
}

[Serializable]
[NetSerializable]
public sealed class HelmetOverlayState : ComponentState
{
    public EntityUid? Equipee;
    public bool GravitySensor;
    public bool? HasGravity;
    public bool HasHud;
    public float? Health;
    public bool HealthSensor;
    public float? InternalsPressure;
    public bool InternalsSensor;
    public float? Pressure;
    public bool PressureSensor;
    public float? Radiation;
    public bool RadiationSensor;
    public string? Texture;
}
