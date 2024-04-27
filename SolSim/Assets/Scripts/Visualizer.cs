using System;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class Visualizer : MonoBehaviour {
    [SerializeField]
    public GameObject Visualization;

    private double logarithmicScale;

    private readonly float scaleFactor = 0.1f;

    public void SetScale(double radiusInEarths, double parentScale) {
        logarithmicScale = Math.Log(radiusInEarths + 1);
        transform.localScale *= scaleFactor * (float)logarithmicScale / (float)parentScale;
    }
}
