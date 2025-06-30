#include <bits/stdc++.h>
using namespace std;

void heapify(vector<int> &m , int n , int i){
    int left = i*2 + 1;
    int right = i*2 + 2;
    int largest = i;
    if (left < n && m[left] > m[largest])
        largest = left;
    if (right < n && m[right] > m[largest])
        largest = right;
    if (largest != i){
        swap(m[i],m[largest]);
        heapify(m,n,largest);
    }
}
void myheap(vector<int> &m){
    for (int i=m.size()/2-1 ; i>=0 ; --i)
        heapify(m,m.size(),i);
    for (int i=m.size()-1 ; i>=0 ; --i){
        swap(m[0],m[i]);
        heapify(m,i,0);
    }
}

void myquick (vector<int> &a, int l, int r){
    if (l >= r) return;
    int pivot = a[(l+r)/2];
    int i = l;
    int j = r;
    while (i <= j){
        while (a[i] < pivot) i++;
        while (pivot < a[j]) j--;
        if (i <= j){
            swap (a[i] , a[j]);
            i++;
            j--;
        }
    }
    myquick(a,l,j);
    myquick(a,i,r);
}

void quick (vector<int> &a, int l, int r){
    if (l >= r) return;
    int pivot = (l+r)/2;
    int i = l;
    int j = r;
    cout << a[pivot] << endl;
    while(i <= j){
        while(a[i] > a[pivot]) i++;
        while(a[pivot] > a[j]) j--;
        if (i <= j){
            swap (a[i],a[j]);
            i++;
            j--;
        }
        for (int x : a)
        cout << x << " ";
            cout << endl;
    }

    quick(a,l,j);
    quick(a,i,r);
}


void selection(vector<int> &a){
    for (int i=0 ; i<a.size()-1 ; ++i){
        int minn = i;
        for (int j=i+1 ; j<a.size() ; ++j)
            if (a[j] < a[minn])
                minn = j;
        swap(a[i],a[minn]);
    }
}


void insertion(vector<int> &a){
    for (int i=1 ; i<a.size() ; ++i){
        int cr = a[i];
        int k;
        for (k=i-1 ; k>=0 && a[k]>cr ; --k)
            a[k+1] = a[k];
        a[k+1] = cr;
    }
}




int main(){
    vector<int> a{10,5,30,70,40,80,90};
    for (int x : a)
        cout << x << " ";
        cout << endl << endl;
    quick(a,0,a.size()-1);

    return 0;
}
