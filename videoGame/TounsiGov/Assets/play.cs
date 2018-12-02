using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class play : MonoBehaviour {
	public static bool ok=false;
	public Text ans1;
	public Text ans2;
	public Text ans3;
	public GameObject score;
	public GameObject scoretext;
	public GameObject button;

	 public void playy(){
	 button.SetActive(false);
	 score.SetActive(true);
	 scoretext.SetActive(true);
	 ok=true;
 }
public void answer1(){
	 if(data.clickedobject.GetComponent<zoom>().ok==false){
		 data.clickedobject.GetComponent<zoom>().ok=true;
		 if(data.clickedobject.GetComponent<zoom>().rightans==ans1.text){
			 data.clickedobject.GetComponent<zoom>().right();
		 }  else {
			 data.clickedobject.GetComponent<zoom>().wrong();
		 }
	 }
 }

public void answer2(){
	 if(data.clickedobject.GetComponent<zoom>().ok==false){
		data.clickedobject.GetComponent<zoom>().ok=true;
		 if(data.clickedobject.GetComponent<zoom>().rightans==ans2.text){
			 data.clickedobject.GetComponent<zoom>().right();
		 }  else {
			 data.clickedobject.GetComponent<zoom>().wrong();
		 }
	 }
 }

 
public void answer3(){
	 if(data.clickedobject.GetComponent<zoom>().ok==false){
		 data.clickedobject.GetComponent<zoom>().ok=true;
		 if(data.clickedobject.GetComponent<zoom>().rightans==ans3.text){
			 data.clickedobject.GetComponent<zoom>().right();
		 } else {
			 data.clickedobject.GetComponent<zoom>().wrong();
		 }
	 }
 }	
}
