using UnityEngine;
using Util;

public class CelestialBody : MonoBehaviour
{
    [SerializeField]
    public double Mass_earths;
    [SerializeField]
    public double Radius_km;
    [SerializeField]
    public Vector3 InitialPosition;
    [SerializeField]
    public Vector3 InitialVelocity;

    public double Mass => mass;
    private double mass;                        // Unit: Solar Masses
    private double radius;                      // Unit: AU
    private double scale;

    private Visualizer visualizer;

    private void Awake() {
        mass = Mass_earths / Constants.SolarMass_InEarths;
        transform.position = InitialPosition;

        scale = radius = Radius_km / Constants.Au_InKm;
        transform.localScale *= (float)radius;

        visualizer = GetComponent<Visualizer>();
        visualizer.SetScale(Radius_km / Constants.EarthRadius_InKm, scale);
    }
}
