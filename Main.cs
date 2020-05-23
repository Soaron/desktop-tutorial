void foo(){
	int a = 1;
	int b = 2;
	inc c = a + b;
}

void MSDestroy(){
	
	GO = MS.GameObject;
	Destroy(GO);
	GO.PlayAnimation();
	
}

void ChangePosition(GameObject GO, Vector3 newPos){
	GO.transform.Position = newPos;
}