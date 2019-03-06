#include <iostream>
using namespace std;

class Cima
{
public:
	Cima()
	{
		real = 1;
		img = 2;
	}
	void show()
	{
		cout << real << "+" << "j" << img << endl;
	}
	~Cima()
	{
		cout << "THE END!" << endl;
	}
private:
	friend Cima operator + (Cima& a, Cima& b);
	int real;
	int img;
};

Cima operator + (Cima& a, Cima& b)
{
	Cima c;
	c.real = a.real + b.real;
	c.img = a.img + b.img;
	return c;
}

int main()
{
	{
		Cima ima1,ima2;
		ima1.show();
		ima2.show();
		Cima ima3;
		ima3 = ima1 + ima2;
		ima3.show();
	}
	system("pause");
	return 0;
}