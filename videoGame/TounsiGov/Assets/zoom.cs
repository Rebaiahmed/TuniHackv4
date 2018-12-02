using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class zoom : MonoBehaviour {
	
	public GameObject qstset1;
	public GameObject qstset2;
	public GameObject qstset3;
	public GameObject qstset4;
	public GameObject n;
	public GameObject k1;
	public GameObject k2;
	public GameObject map;
	public GameObject k;
	public string rightans;
	public bool ok=false;
	bool imclicked=false;
	public Text name;
	public string myname;
	public GameObject qst;
	public GameObject b1;
	public Text b11;
	public GameObject b2;
	public Text b22;
	public GameObject b3;
	public Text b33;
	public GameObject score;
	public string myqst;
	public string ans1;
	public string ans2;
	public string ans3;
	
	SpriteRenderer sr;
	public Color c;
	// Use this for initialization
	void Start () {
		sr=GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}	
	void OnMouseOver()
 {
   if(play.ok){ if(! imclicked){
	    sr.color=c;
   name.text=myname;
   }
   }

 }
 void OnMouseExit()
 {
     if(play.ok)  {
		 if(!imclicked){
			 sr.color=Color.white;
		name.text=" ";
		 }
		 
	 }
 }

 void OnMouseDown(){
	if(play.ok) {
		
				if(!imclicked){
		sr.color=c;
		name.text=myname;
		imclicked=true;
		data.clickedobject=this.gameObject;
		qst.GetComponent<Text>().text=myqst;
		if(name.text!="kawrawen" && name.text!="nabeul"){
		b11.text=ans1;
		b22.text=ans2;
		b33.text=ans3;
		qst.SetActive(true);
		b1.SetActive(true);
		b2.SetActive(true);
		b3.SetActive(true);
		}
		else if(name.text=="kawrawen"){
		map.SetActive(false);
			k.SetActive(true);
			qstset1.SetActive(true);
		} else if(name.text=="nabeul"){
		map.SetActive(false);
			n.SetActive(true);
			qstset3.SetActive(true);
		} 

		} else {
			imclicked=false;
			sr.color=Color.white;
			name.text=myname;
			qst.GetComponent<Text>().text="";
		qst.SetActive(false);
		b1.SetActive(false);
		b2.SetActive(false);
		b3.SetActive(false);
		data.clickedobject=null;
		}
	
	}
 }



 public void right (){
	 data.score=data.score+10;
	 score.GetComponent<Text>().text=data.score.ToString();
	 qst.SetActive(false);
	 b1.SetActive(false);
	 b2.SetActive(false);
	 b3.SetActive(false);
 }

 public void wrong (){
	 qst.SetActive(false);
	 b1.SetActive(false);
	 b2.SetActive(false);
	 b3.SetActive(false);
 }
//********************** */
public void rightK1(){
data.score=data.score+10;
	 score.GetComponent<Text>().text=data.score.ToString();
	 qstset1.SetActive(false);
	 qstset2.SetActive(true);
}

public void wrongk1(){
	 qstset1.SetActive(false);
	 qstset2.SetActive(true);
}

 public void rightk2(){
	 data.score=data.score+10;
	 score.GetComponent<Text>().text=data.score.ToString();
	 qstset2.SetActive(false);
	 map.SetActive(true);
	 k.SetActive(false);
	 imclicked=false;
	 sr.color=Color.white;
	 name.text=" ";
	 		data.clickedobject=null;
 }

 public void wrongk2(){
	 qstset2.SetActive(false);
	 map.SetActive(true);
	 k.SetActive(false);
	 imclicked=false;
	 sr.color=Color.white;
	 name.text=" ";
	 		data.clickedobject=null;
 }
 
 /*********/ 
public void rightK1n(){
data.score=data.score+10;
	 score.GetComponent<Text>().text=data.score.ToString();
	 qstset3.SetActive(false);
	 qstset4.SetActive(true);
}

public void wrongk1n(){
	 qstset3.SetActive(false);
	 qstset4.SetActive(true);
}

 public void rightk2n(){
	 data.score=data.score+10;
	 score.GetComponent<Text>().text=data.score.ToString();
	 qstset4.SetActive(false);
	 map.SetActive(true);
	 n.SetActive(false);
	 imclicked=false;
	 sr.color=Color.white;
	 name.text=" ";
	 		data.clickedobject=null;
 }

 public void wrongk2n(){
	 qstset4.SetActive(false);
	 map.SetActive(true);
	 n.SetActive(false);
	 imclicked=false;
	 sr.color=Color.white;
	 name.text=" ";
	 		data.clickedobject=null;
 }
}
