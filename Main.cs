void foo(){
	int a = 1;
	int b = 3;
	inc c = a + b;
}

void MSDestroy(GameObject GO){
	GO.PlayAnimation();
	Destroy(GO);
}

void ChangePosition(GameObject GO, Vector3 newPos){
	GO.transform.Position = newPos;
}