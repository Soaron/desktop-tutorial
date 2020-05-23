void foo(){
	int a = 1;
	int b = 3;
	inc c = a + b;
}

void MSDestroy(GameObject GO){
	Destroy(GO);
	GO.PlayAnimation();
	
}

void ChangePosition(GameObject GO, Vector3 newPos){
	GO.transform.Position = newPos;
}