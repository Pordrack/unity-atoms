using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference Listener of type `Vector2Pair`. Inherits from `AtomEventReferenceListener&lt;Vector2Pair, Vector2PairAction, Vector2PairEvent, Vector2PairEventReference, Vector2PairUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Event Reference Listeners/Vector2Pair Event Reference Listener")]
    public sealed class Vector2PairEventReferenceListener : AtomEventReferenceListener<
        Vector2Pair,
        Vector2PairAction,
        Vector2PairEvent,
        Vector2PairEventReference,
        Vector2PairUnityEvent>
    { }
}