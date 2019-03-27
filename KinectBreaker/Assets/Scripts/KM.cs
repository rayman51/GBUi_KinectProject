using System.Collections;
using System.Collections.Generic;
using Windows.Kinect;
using UnityEngine;

using UnityEngine.UI;
using System.Linq;


public class KM : MonoBehaviour
{
    private KinectSensor sensor;
    private BodyFrameReader bodyFrameReader;
    private Body[] bodies = null;

    public GameObject kinectAvailabeText;
    public Text handXTest;

    public bool IsAvailable;
    public float PaddlePosition;
    public bool IsFire;

    public static KM instance = null;


    public Body[] GetBobies()
    {
        return bodies;
    }

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
            Destroy(gameObject);
    }


    // Start is called before the first frame update
    void Start()
    {
        sensor = KinectSensor.GetDefault();

        if (sensor != null)
        {
            IsAvailable = sensor.IsAvailable;
            kinectAvailabeText.SetActive(IsAvailable);
            bodyFrameReader = sensor.BodyFrameSource.OpenReader();

            if (!sensor.IsOpen)
            {
                sensor.Open();
            }// if

            bodies = new Body[sensor.BodyFrameSource.BodyCount];

        }// if
    }// start

    // Update is called once per frame
    void Update()
    {
        
    }
}
