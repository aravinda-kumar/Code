struct MyStruct
{
	double time;
	double value;
	bool operator <(MyStruct item)
	{
		if(time<item.time) 
			return true;
		else 
			return false; 
	}
};
