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


    public Body[] GetBodies()
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
        IsAvailable = sensor.IsAvailable;
        
        if(bodyFrameReader != null)
        {
            var frame = bodyFrameReader.AcquireLatestFrame();

            if(frame != null)
            {
                frame.GetAndRefreshBodyData(bodies);

                foreach (var body in bodies.Where(b => b.IsTracked))
                {
                    IsAvailable = true;

                    if(body.HandRightConfidence == TrackingConfidence.High && body.HandRightState == HandState.Lasso)
                    {
                        IsFire = true;
                    }//if
                    else
                    {
                        PaddlePosition = RescalingToRangeB(-1, 1, -8, 8, body.Lean.X);
                        handXTest.text = PaddlePosition.ToString();
                    }//else
                }//foreach

                frame.Dispose();
                frame = null;

            }//inner if

        }//outer if 

    }//Update

    static float RescalingToRangeB(float scaleAStart, float scaleAEnd, float scaleBStart, float scaleBEnd, float valueA)
    {
        return (((valueA - scaleAStart) * (scaleBEnd - scaleBStart)) / (scaleAEnd - scaleBStart)) + scaleBStart;
    }//RescalingToRangeB

    void OnApplicationQuit()
    {
        if(bodyFrameReader != null)
        {
            bodyFrameReader.IsPaused = true;
            bodyFrameReader.Dispose();
            bodyFrameReader = null;
        }//if 

        if(sensor != null)
        {
            if(sensor.IsOpen)
            {
                sensor.Close();
            }

            sensor = null;
        }//if

    }//OnApplicationQuit

}//KM
