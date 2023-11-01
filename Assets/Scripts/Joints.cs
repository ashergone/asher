using UnityEngine;
using System.Collections;

public class Joints : MonoBehaviour {
	GameObject Tractor;
	GameObject trolley;
	GameObject JointBtn;
	GameObject Camera;
	GameObject Hal;
	GameObject haldown;
	GameObject watertank;
	GameObject WaterTankBTN;
	GameObject Spraytank;
	public GameObject harvesthall;
	public static bool TrolleyJointcheck;
	public static int jointcounter;
	// Use this for initialization
	void Awake(){
		haldown = GameObject.Find ("HalDown");
	}
	void Start () {
		

		TrolleyJointcheck = false;
		JointBtn = GameObject.Find ("JointBTN");
		JointBtn.SetActive (false);
		WaterTankBTN = GameObject.Find ("WatetankBTN");
		WaterTankBTN.SetActive (false);
		Tractor = gameObject.transform.parent.gameObject;
		trolley = GameObject.Find ("Model_Trailer");
		watertank = GameObject.Find ("WaterTank");
		Camera = GameObject.FindWithTag ("MainCamera");
		Spraytank = GameObject.FindWithTag ("SprayTank");
		Hal = GameObject.FindWithTag ("halltractor");
	}
	public void jointTrolley(){
		TrolleyJointcheck = true;
		Camera.GetComponent<RCCCarCamera> ().distance = 17;
		Camera.GetComponent<RCCCarCamera> ().height = 9;
		JointBtn.SetActive (false);
		trolley.transform.parent = Tractor.transform;
		trolley.GetComponent<RCCTruckTrailer> ().enabled = true;
		trolley.GetComponent<ConfigurableJoint> ().connectedBody = Tractor.GetComponent<Rigidbody>();
	}
	public void Watertankjoint(){
		

		WaterTankBTN.SetActive (true);
		TrolleyJointcheck = true;
		Camera.GetComponent<RCCCarCamera> ().distance = 17;
		Camera.GetComponent<RCCCarCamera> ().height = 9;
		JointBtn.SetActive (false);
		watertank.transform.parent = Tractor.transform;
		watertank.GetComponent<RCCTruckTrailer> ().enabled = true;
		watertank.GetComponent<ConfigurableJoint> ().connectedBody = Tractor.GetComponent<Rigidbody>();
	}
	public void DisconnectjointWatertank(){
		
		WaterTankBTN.SetActive (false);
		TrolleyJointcheck = false;
		Camera.GetComponent<RCCCarCamera> ().distance = 9;
		Camera.GetComponent<RCCCarCamera> ().height = 6;
		watertank.GetComponent<RCCTruckTrailer> ().enabled = false;
		watertank.transform.parent = null;
		watertank.GetComponent<ConfigurableJoint> ().connectedBody = null;
		WaterTankBTN.SetActive (false);
	}
	public void DisconnectjointTrolley(){
		TrolleyJointcheck = false;
		Camera.GetComponent<RCCCarCamera> ().distance = 9;
		Camera.GetComponent<RCCCarCamera> ().height = 6;
		trolley.GetComponent<RCCTruckTrailer> ().enabled = false;
		trolley.transform.parent = null;
		trolley.GetComponent<ConfigurableJoint> ().connectedBody = null;
	}
	public void halljoint(){
		//haldown.SetActive (true);
		RCCWheelCollider1.hallcheck = true;
		Hal.transform.parent = Tractor.transform;
	}
	public void hallunjoint(){
		//haldown.SetActive (false);

		RCCWheelCollider1.hallcheck = false;
		Hal.transform.parent = null;
	}
	public void SprayTankJoint(){
		
		TrolleyJointcheck = true;
		Camera.GetComponent<RCCCarCamera> ().distance = 17;
		Camera.GetComponent<RCCCarCamera> ().height = 9;
		Spraytank.transform.parent = Tractor.transform;
		WaterTankBTN.SetActive (true);
	}
	public void SprayTankUnJoint(){
		
		Camera.GetComponent<RCCCarCamera> ().distance = 9;
		Camera.GetComponent<RCCCarCamera> ().height = 6;
		Spraytank.transform.parent = null;
		WaterTankBTN.SetActive (false);
	}
	void OnTriggerEnter(Collider other) {
		if (other.transform.tag == "Trolley") {
			jointcounter = 1;
			JointBtn.SetActive (true);
		}
		if (other.transform.tag == "WaterTankJoint") {
			jointcounter = 7;
			JointBtn.SetActive (true);

		}

		if (other.transform.tag == "Hall") {
			jointcounter = 3;
			JointBtn.SetActive (true);
		}
		if (other.transform.tag == "SprayJoint") {
			JointBtn.SetActive (true);

			jointcounter = 5;
		}
	}

	void OnTriggerExit(Collider other) {
		if (other.transform.tag == "Trolley") {
			jointcounter = 2;
			JointBtn.SetActive (false);
		}
		if (other.transform.tag == "WaterTankJoint") {
			jointcounter = 8;
			JointBtn.SetActive (false);

		}
		if (other.transform.tag == "Hall") {
			jointcounter = 4;
			JointBtn.SetActive (false);
		}
		if (other.transform.tag == "SprayJoint") {
			Debug.Log ("fdsafsd");
			jointcounter = 6;
			JointBtn.SetActive (false);

		}
	}
	// Update is called once per frame
	void Update () {
	
	}
}
