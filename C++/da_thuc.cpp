/*###Begin banned keyword - each of the following line if appear in code will raise error. regex supported
###End banned keyword*/
#include <bits/stdc++.h>
using namespace std;


struct DONTHUC{
	int somu;
	double heso;

	DONTHUC(double _heso = 0,int _somu=0){
		heso = _heso;
		somu  = _somu;
	}

	DONTHUC& operator = (const DONTHUC &rhs){
		if (this == &rhs) return *this;
		this->heso = rhs.heso;
		this->somu = rhs.somu;
		return *this;
	}
};


struct Node{
	DONTHUC* data;
	Node* next;

	Node(DONTHUC* _data = nullptr){
		this->data = _data;
		this->next = nullptr;
	}

};

struct DATHUC{
	Node* head;
	Node* tail;
	DATHUC(){
		this->head = nullptr;
		this->tail = nullptr;
	}
};


//###INSERT CODE HERE -
void Nhap(DATHUC &b, double heso, int somu){
    DONTHUC* a = new DONTHUC(heso,somu);
    Node* newnode = new Node(a);
    if (b.head == nullptr)
        b.head = newnode;
    else
        b.tail->next = newnode;
    b.tail = newnode;
}
void Xuat(DATHUC b){
    if (b.head == nullptr){
        cout << 0;
        return;
    }
    DATHUC a = b;
    int check = 0;
    int c1=0;
    int c2=0;

        if (a.head->data->heso == 1 && a.head->data->somu != 0){
            cout << "x^" << a.head->data->somu;
            check = 1;
        }
        else if (a.head->data->heso == -1 && a.head->data->somu != 0)
            {cout << "-x^" << a.head->data->somu; check =1;}
//

        else if (a.head->data->heso == 1 && a.head->data->somu == 0)
            {cout << 1; check = 1;}
        else if (a.head->data->heso == -1 && a.head->data->somu == 0)
            {cout << -1;check = 1;}
//

        else if (a.head->data->heso > 0 && a.head->data->somu == 0)
            {cout << a.head->data->heso;check = 1;}
        else if (a.head->data->heso < 0 && a.head->data->somu == 0)
            {cout << a.head->data->heso;check = 1;}
//

        else if (a.head->data->heso > 0 && a.head->data->somu == 1)
            {cout << a.head->data->heso << "x"; check = 1;}
        else if (a.head->data->heso < 0 && a.head->data->somu == 1)
            {cout << a.head->data->heso << "x";check = 1;}

        else if (a.head->data->heso > 0)
            {cout << a.head->data->heso << "x^" << a.head->data->somu;check = 1;}
        else if (a.head->data->heso < 0)
            {cout << a.head->data->heso << "x^" << a.head->data->somu;check = 1;}

    a.head = a.head->next;
    while (a.head){
//
        if (a.head->data->heso == 1 && a.head->data->somu != 0)
            cout << "+x^" << a.head->data->somu;
        else if (a.head->data->heso == -1 && a.head->data->somu != 0)
            cout << "-x^" << a.head->data->somu;
//

        else if (a.head->data->heso == 1 && a.head->data->somu == 0)
            cout << 1;
        else if (a.head->data->heso == -1 && a.head->data->somu == 0)
            cout << -1;
//

        else if (a.head->data->heso > 0 && a.head->data->somu == 0)
            cout << "+" << a.head->data->heso;
        else if (a.head->data->heso < 0 && a.head->data->somu == 0)
            cout << a.head->data->heso;
//

        else if (a.head->data->heso > 0 && a.head->data->somu == 1)
            cout << "+" << a.head->data->heso << "x";
        else if (a.head->data->heso < 0 && a.head->data->somu == 1)
            cout << a.head->data->heso << "x";

        else if (a.head->data->heso > 0)
            cout << "+" << a.head->data->heso << "x^" << a.head->data->somu;
        else if (a.head->data->heso < 0)
            cout << a.head->data->heso << "x^" << a.head->data->somu;
//
        else c1++;

        c2++;
        a.head = a.head->next;
    }
    if (check == 0 && c1 == c2) cout << 0;
}
double TinhDaThuc(DATHUC b, double x){
    double result = 0;
    while (b.head){
        result += b.head->data->heso * pow(x,b.head->data->somu);
        b.head = b.head->next;
    }
    return result;
}



int main() {
    DATHUC B;
    int N;

    cin >> N;
    for (int test = 0; test < N; test++){
		double heso; int somu;
		cin >> heso >> somu;
		Nhap(B,heso,somu);
    }


    cout << "Da thuc vua nhap la: "; Xuat(B);
    double x; cin >> x;
    cout << "\nVoi x=" << x << ", gia tri da thuc la: "
         << setprecision(2) << fixed << TinhDaThuc(B, x);
    return 0;
}
