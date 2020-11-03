#include<iostream>
#include<string>
#include <cmath>
#include <cstdlib>
#include <ctime>
using namespace std;
int main(){
	string name;
	int date;
	string course;
	cout<<"Welcome what is your name?\n";
	cin>>name;
	cout<<"Hello "<<name<<" Good day to you!\n";
	cout<<"What  is Today's date?\n";
	cin>>date;
	system("cls");
	cout<<time(ctime);
	system("pause");
}
