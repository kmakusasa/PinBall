using UnityEngine;
using System.Collections;

public class FripperController : MonoBehaviour
{
    
    private HingeJoint myHingeJoint;

   
    private readonly float defaultAngle = 20;
   
    private readonly float flickAngle = -20;

    
    void Start()
    {
        
        this.myHingeJoint = GetComponent<HingeJoint>();

        
        SetAngle(this.defaultAngle);
    }

    
    void Update()
    {

        
        if (Input.GetKeyDown(KeyCode.LeftArrow) && tag == "LeftFripperTag") {
        SetAngle(this.flickAngle);
        }
        
        if (Input.GetKeyDown(KeyCode.RightArrow) && tag == "RightFripperTag") {
        SetAngle(this.flickAngle);
        }

        
        if (Input.GetKeyUp(KeyCode.LeftArrow) && tag == "LeftFripperTag") {
        SetAngle(this.defaultAngle);
        }
        if (Input.GetKeyUp(KeyCode.RightArrow) && tag == "RightFripperTag") {
        SetAngle(this.defaultAngle);
        }
    }

    
    public void SetAngle(float angle)
    {
        JointSpring jointSpr = this.myHingeJoint.spring;
        jointSpr.targetPosition = angle;
        this.myHingeJoint.spring = jointSpr;
    }
}