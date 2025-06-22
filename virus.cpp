#include <bits/stdc++.h>
using namespace std;
double RandomDouble() {
    return static_cast<double>(rand()) / RAND_MAX;
}

class virus {
public:
    virtual void TrieuChungCu(int) = 0;
    virtual void TrieuChungMoi(int) = 0;
    virtual bool TuVongCu(int) = 0;
    virtual bool TuVongMoi(int) = 0;
};
class Sars : public virus {
public:
    void TrieuChungCu(int);
    void TrieuChungMoi(int);
    bool TuVongCu(int);
    bool TuVongMoi(int);
};
void Sars::TrieuChungCu(int x){
    double r = RandomDouble();
    if (x == 1){
        if (r >= 0.85)
            cout << "Sot cao, ho khan, kho tho,dau dau\n";
        else if (r >= 0.65)
            cout << "Sot, ho, mat vi giac vai ngay\n";
        else
            cout << "Khong trieu chung\n";
    }
    else if (x == 2){
        if (r >= 0.9)
            cout << "Khong trieu chung\n";
        else if (r >= 0.6)
            cout << "Sot, ho, mat vi giac vai ngay\n";
        else
            cout << "Sot cao, ho khan, kho tho,dau dau\n";
    }
    else {
        if (r >= 0.95)
            cout << "Khong trieu chung\n";
        else if (r >= 0.85)
            cout << "Sot, ho, mat vi giac vai ngay\n";
        else
            cout << "Sot cao, ho khan, kho tho,dau dau\n";
    }
}
void Sars::TrieuChungMoi(int x){
    double r = RandomDouble();
    if (x == 1){
        if (r >= 0.95)
            cout << "Sot cao, ho khan, kho tho,dau dau\n";
        else if (r >= 0.75)
            cout << "Sot, ho, mat vi giac vai ngay\n";
        else
            cout << "Khong trieu chung\n";
    }
    else if (x == 2){
        if (r >= 0.8)
            cout << "Khong trieu chung\n";
        else if (r >= 0.7)
            cout << "Sot cao, ho khan, kho tho,dau dau\n";
        else
            cout << "Sot, ho, mat vi giac vai ngay\n";
    }
    else {
        if (r >= 0.9)
            cout << "Khong trieu chung\n";
        else if (r >= 0.6)
            cout << "Sot, ho, mat vi giac vai ngay\n";
        else
            cout << "Sot cao, ho khan, kho tho,dau dau\n";
    }
}
bool Sars::TuVongCu(int x){
    return false;
}
bool Sars::TuVongMoi(int x){
    return false;
}



class Ebola : public virus {
public:
    void TrieuChungCu(int);
    void TrieuChungMoi(int);
    bool TuVongCu(int);
    bool TuVongMoi(int);
};
void Ebola::TrieuChungCu(int x){
    double r = RandomDouble();
    if (x == 1){
        if (r >= 0.85)
            cout << "Non mua, tieu chay, xuat huyet\n";
        else if (r >= 0.65)
            cout << "Sot, dau hong, dau co, dau dau\n";
        else
            cout << "Khong trieu chung\n";
    }
    else if (x == 2){
        if (r >= 0.9)
            cout << "Khong trieu chung\n";
        else if (r >= 0.6)
            cout << "Sot, dau hong, dau co, dau dau\n";
        else
            cout << "Non mua, tieu chay, xuat huyet\n";
    }
    else {
        if (r >= 0.95)
            cout << "Khong trieu chung\n";
        else if (r >= 0.85)
            cout << "Sot, dau hong, dau co, dau dau\n";
        else
            cout << "Non mua, tieu chay, xuat huyet\n";
    }
}
void Ebola::TrieuChungMoi(int x){
    double r = RandomDouble();
    if (x == 1){
        if (r >= 0.95)
            cout << "Non mua, tieu chay, xuat huyet\n";
        else if (r >= 0.75)
            cout << "Sot, dau hong, dau co, dau dau\n";
        else
            cout << "Khong trieu chung\n";
    }
    else if (x == 2){
        if (r >= 0.8)
            cout << "Khong trieu chung\n";
        else if (r >= 0.7)
            cout << "Non mua, tieu chay, xuat huyet\n";
        else
            cout << "Sot, dau hong, dau co, dau dau\n";
    }
    else {
        if (r >= 0.9)
            cout << "Khong trieu chung\n";
        else if (r >= 0.6)
            cout << "Sot, dau hong, dau co, dau dau\n";
        else
            cout << "Non mua, tieu chay, xuat huyet\n";
    }
}
bool Ebola::TuVongCu(int x){
    if (x == 1){
        if (0.5 * 0.5 >= 0.5) return true;
    }
    else if (x == 2){
        if (0.7 * 0.5 >= 0.5) return true;
    }
    else{
        if (1 * 0.5 >= 0.5) return true;
    }
    return false;
}
bool Ebola::TuVongMoi(int x){
    if (x == 1){
        if (0.4 * 0.5 >= 0.5) return true;
    }
    else if (x == 2){
        if (0.6 * 0.5 >= 0.5) return true;
    }
    else{
        if (0.8 * 0.5 >= 0.5) return true;
    }
    return false;
}


class HIV : public virus {
public:
    void TrieuChungCu(int);
    void TrieuChungMoi(int);
    bool TuVongCu(int);
    bool TuVongMoi(int);
};
void HIV::TrieuChungCu(int x){
    double r = RandomDouble();
    if (x == 1){
        if (r >= 0.95)
            cout << "Met moi cuc do, sung hach, lo loet, tieu chay nang\n";
        else if (r >= 0.75)
            cout << "Cam, sot\n";
        else
            cout << "Khong trieu chung\n";
    }
    else if (x == 2){
        if (r >= 0.8)
            cout << "Khong trieu chung\n";
        else if (r >= 0.7)
            cout << "Met moi cuc do, sung hach, lo loet, tieu chay nang\n";
        else
            cout << "Cam, sot\n";
    }
    else {
        if (r >= 0.9)
            cout << "Khong trieu chung\n";
        else if (r >= 0.6)
            cout << "Cam, sot\n";
        else
            cout << "Met moi cuc do, sung hach, lo loet, tieu chay nang\n";
    }
}
void HIV::TrieuChungMoi(int x){
    double r = RandomDouble();
    if (x == 1){
        if (r >= 0.95)
            cout << "Met moi cuc do, sung hach, lo loet, tieu chay nang\n";
        else if (r >= 0.75)
            cout << "Cam, sot\n";
        else
            cout << "Khong trieu chung\n";
    }
    else if (x == 2){
        if (r >= 0.8)
            cout << "Khong trieu chung\n";
        else if (r >= 0.7)
            cout << "Met moi cuc do, sung hach, lo loet, tieu chay nang\n";
        else
            cout << "Cam, sot\n";
    }
    else {
        if (r >= 0.9)
            cout << "Khong trieu chung\n";
        else if (r >= 0.6)
            cout << "Cam, sot\n";
        else
            cout << "Met moi cuc do, sung hach, lo loet, tieu chay nang\n";
    }
}
bool HIV::TuVongCu(int x){
    if (x == 1){
        if (0.5 * 0.9 >= 0.5) return true;
    }
    else if (x == 2){
        if (0.7 * 0.9 >= 0.5) return true;
    }
    else{
        if (1 * 0.9 >= 0.5) return true;
    }
    return false;
}
bool HIV::TuVongMoi(int x){
    if (x == 1){
        if (0.4 * 0.9 >= 0.5) return true;
    }
    else if (x == 2){
        if (0.6 * 0.9 >= 0.5) return true;
    }
    else{
        if (0.8 * 0.9 >= 0.5) return true;
    }
    return false;
}


class VatChu {
private:
    string id;
    int miendich;
    vector<virus*> benh;
public:
    void nhap();
    void TrieuChungCu();
    void TrieuChungMoi();
    void TuVongCu();
    void TuVongMoi();
};
void VatChu::nhap(){
    cin >> id;
    miendich = 1 + rand()%3;
    virus* a;
    a = new Sars;
    benh.push_back(a);
    a = new Ebola;
    benh.push_back(a);
    a = new HIV;
    benh.push_back(a);
}
void VatChu::TrieuChungCu(){
    cout << id << endl;
    for (int i=0 ; i<3 ; ++i)
        benh[i]->TrieuChungCu(miendich);
}
void VatChu::TrieuChungMoi(){
    cout << id << endl;
    for (int i=0 ; i<3 ; ++i)
        benh[i]->TrieuChungMoi(miendich);
}
void VatChu::TuVongCu(){
    cout << id << ": ";
    int die = 0;
    for (int i=0 ; i<3 ; ++i)
        if (benh[i]->TuVongCu(miendich))
            die = 1;
    if (die == 0)
        cout << "Ko die\n";
    else
        cout << "Die\n";
}
void VatChu::TuVongMoi(){
    cout << id << ": ";
    int die = 0;
    for (int i=0 ; i<3 ; ++i)
        if (benh[i]->TuVongMoi(miendich))
            die = 1;
    if (die == 0)
        cout << "Ko die\n";
    else
        cout << "Die\n";
}

class quanly {
private:
    vector<VatChu> n,m;
public:
    void nhapn();
    void xuatn();
    void nhapm();
    void xuatm();
};
void quanly::nhapn(){
    int x;
    cin >> x;
    for (int i=0 ; i<x ; ++i){
        VatChu a;
        a.nhap();
        n.push_back(a);
    }
}
void quanly::xuatn(){
    cout << "\n=========Trieu chung=========\n";
    for (int i=0 ; i<n.size() ; ++i)
        n[i].TrieuChungCu();
    cout << "\n===========Tu vong===========\n";
    for (int i=0 ; i<n.size() ; ++i)
        n[i].TuVongCu();
}
void quanly::nhapm(){
    int x;
    cin >> x;
    for (int i=0 ; i<x ; ++i){
        VatChu a;
        a.nhap();
        m.push_back(a);
    }
}
void quanly::xuatm(){
    cout << "\n=========Trieu chung=========\n";
    for (int i=0 ; i<m.size() ; ++i)
        m[i].TrieuChungMoi();
    cout << "\n===========Tu vong===========\n";
    for (int i=0 ; i<m.size() ; ++i)
        m[i].TuVongMoi();
}

int main(){
    srand(time(0));
    while(1){
//nhap so vat chu sau do nhap ID tung vat chu
        quanly a;
        a.nhapn();
        a.xuatn();
        cout << "\n=========================================\n";
//nhap so vat chu sau do nhap ID tung vat chu
        a.nhapm();
        a.xuatm();
        cout << "\n=========================================================\n";
        cout << "=========================================================\n";
    }
    return 0;
}
