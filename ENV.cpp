//https://www.hackerrank.com/contests/de-thi-thuc-hanh/challenges/mang-dien/problem
#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <algorithm>
using namespace std;
#include <bits/stdc++.h>
struct thoidiem {
    int gio,tocdogio,may,tongcongsuattieuthu;
};

class NguonDien {
protected:
    int HieuSuat;
public:
    virtual void Nhap();
    virtual int getLoai() = 0;
    virtual double CongSuat() = 0;
    virtual int tichtru(){return 0;};
};
void NguonDien::Nhap(){
    cin >> HieuSuat;
}
///////////////////////////////////////
///////////////////////////////////////
///////////////////////////////////////
///////////////////////////////////////
class ThuyDien : public NguonDien {
private:
    int SoToMay;
    int TichNang;
public:
    int tichtru(){return TichNang == 1 ? SoToMay*HieuSuat : 0;};
    void Nhap();
    double CongSuat();
    int getLoai(){return 1;};
};
void ThuyDien::Nhap(){
    NguonDien::Nhap();
    cin >> SoToMay >> TichNang;
}
double ThuyDien::CongSuat(){
    return HieuSuat*SoToMay;
}

///////////////////////////////////////
///////////////////////////////////////
///////////////////////////////////////
///////////////////////////////////////
class NhietDien : public NguonDien {
private:
    int SoLuongThan;
public:
    void Nhap();
    double CongSuat();
    int getLoai(){return 2;};
};
void NhietDien::Nhap(){
    NguonDien::Nhap();
    cin >> SoLuongThan;
}
double NhietDien::CongSuat(){
    return HieuSuat*SoLuongThan;
}
///////////////////////////////////////
///////////////////////////////////////
///////////////////////////////////////
///////////////////////////////////////
class DienGio : public NguonDien {
private:
    int SoToTuaBin;
    int TocDoGioToiDa;
public:
    void Nhap();
    double CongSuat();
    int getLoai(){return 3;};
};
void DienGio::Nhap(){
    NguonDien::Nhap();
    cin >> SoToTuaBin >> TocDoGioToiDa;
}
double DienGio::CongSuat(){
    return HieuSuat*SoToTuaBin/(double)TocDoGioToiDa;
}
///////////////////////////////////////
///////////////////////////////////////
///////////////////////////////////////
///////////////////////////////////////
class DienMatTroi : public NguonDien {
private:
    int DienTich;
public:
    void Nhap();
    double CongSuat();
    int getLoai(){return 4;};
};
void DienMatTroi::Nhap(){
    NguonDien::Nhap();
    cin >> DienTich;
}
double DienMatTroi::CongSuat(){
    return HieuSuat*DienTich;
}
///////////////////////////////////////
///////////////////////////////////////
///////////////////////////////////////
///////////////////////////////////////
int main() {
    vector<NguonDien*> nguon;
    int x;
    cin >> x;
    for (int i=0 ; i<x ; ++i){
        int pick;
        cin >> pick;
        if (pick == 1){
            NguonDien *a;
            a = new ThuyDien;
            a->Nhap();
            nguon.push_back(a);
        }
        else if (pick == 2){
            NguonDien *a;
            a = new NhietDien;
            a->Nhap();
            nguon.push_back(a);
        }
        else if (pick == 3){
            NguonDien *a;
            a = new DienGio;
            a->Nhap();
            nguon.push_back(a);
        }
        else {
            NguonDien *a;
            a = new DienMatTroi;
            a->Nhap();
            nguon.push_back(a);
        }
    }
    vector<thoidiem> tg;
    cin >> x;
    for (int i=0 ; i<x ; ++i){
        thoidiem a;
        cin >> a.gio >> a.tocdogio >> a.may >> a.tongcongsuattieuthu;
        tg.push_back(a);
    }
    int maxtichtru = 0;
    for (int j=0 ; j<nguon.size() ; ++j){
        if (nguon[j]->getLoai() == 1 && nguon[j]->tichtru() > 0)
            maxtichtru += nguon[j]->tichtru();
    }

    float tongtien = 0;
    vector<double> congsuatsanxuat;
    int tich = 0;

    int count = -1;
    for (int i=0 ; i<tg.size() ; ++i){
        double sum = 0;
        for (int j=0 ; j<nguon.size() ; ++j){
            if (nguon[j]->getLoai() == 1){
                sum += nguon[j]->CongSuat();
            }
            else if (nguon[j]->getLoai() == 2){
                sum += nguon[j]->CongSuat();
            }
            else if (nguon[j]->getLoai() == 3){
                if (count > 0) continue;
                sum += nguon[j]->CongSuat()*tg[i].tocdogio;
            }
            else {
                if (count > 0) continue;
                if (tg[i].may == 1) continue;
                if (tg[i].gio >= 11 && tg[i].gio <= 13)
                    sum += nguon[j]->CongSuat();
                else if (tg[i].gio > 13 && tg[i].gio < 18)
                    sum += nguon[j]->CongSuat()*(1 - 0.2*(tg[i].gio-13));
                else if (tg[i].gio > 6 && tg[i].gio < 11)
                    sum += nguon[j]->CongSuat()*(0.2*(tg[i].gio-6));
            }
        }
        if (count != -1)
            count--;
        if (!congsuatsanxuat.empty() && count == -1){
            if (sum < 0.8 * congsuatsanxuat[congsuatsanxuat.size()-1] || sum > 1.2 * congsuatsanxuat[congsuatsanxuat.size()-1]){
                count = 2;
            }
        }
        congsuatsanxuat.push_back(sum);

        if (tich != 0 && sum < tg[i].tongcongsuattieuthu){
            sum += tich;
            tich = 0;
        }
        else if (tich != 0 && sum > tg[i].tongcongsuattieuthu){
            tich = tich+((int(sum) == sum ? sum : int(sum+1)) - tg[i].tongcongsuattieuthu) < maxtichtru ? tich+((int(sum) == sum ? sum : int(sum+1)) - tg[i].tongcongsuattieuthu) : maxtichtru;
        }

        if (sum <= tg[i].tongcongsuattieuthu*0.5){
            tongtien += (int(sum) == sum ? sum : int(sum+1)) * 1000 * 2000;
        }
        else if (sum < tg[i].tongcongsuattieuthu*0.8){
            tongtien += (int(sum) == sum ? sum : int(sum+1)) * 1000 * 2500;
        }
        else if (sum <= tg[i].tongcongsuattieuthu && sum >= tg[i].tongcongsuattieuthu*0.8){
            tongtien += (int(sum) == sum ? sum : int(sum+1)) * 1000 * 3000;
        }
        else if (sum > tg[i].tongcongsuattieuthu){
            tongtien += tg[i].tongcongsuattieuthu * 1000 * 3000;
            if (tich == 0)
            tich = (int(sum) == sum ? sum : int(sum+1)) - tg[i].tongcongsuattieuthu < maxtichtru ? (int(sum) == sum ? sum : int(sum+1)) - tg[i].tongcongsuattieuthu : maxtichtru;
        }
    }

    cout << fixed << setprecision(0) << tongtien;
    return 0;
}
