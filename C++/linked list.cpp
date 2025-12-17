#include <bits/stdc++.h>
using namespace std;

struct Node {
    int info;
    Node * next;
};

Node* creatNode(int x){
    Node *newNode;
    newNode = new Node;
    newNode->info = x;
    newNode->next = nullptr;
    return newNode;
}

struct myList {
    Node *head;
    Node *tail;
};

void creatList(myList &a){
    a.head = nullptr;
    a.tail = nullptr;
}

void addHead(myList &a, Node *x){
    if (a.head == nullptr)
        a.head = a.tail = x;
    else{
        x->next = a.head;
        a.head = x;
    }
}

void addTail(myList &a, Node *x){
    if (a.tail == nullptr)
        a.head = a.tail = x;
    else{
        a.tail->next = x;
        a.tail = x;
    }
}

void removeAfter(myList &a, Node *x){
    if (x->next == a.tail)
        a.tail = x;
    Node *p = new Node;
    p = x->next;
    x->next = p->next;
    p->next = nullptr;
    delete p;
}


void printList(myList &a){
    if (a.head == nullptr)
        return;
    Node *p = a.head;
    while (p){
        cout << p->info << " ";
        p = p->next;
    }
}

Node* removeHead(myList &a){
    if (a.head == nullptr)
        return nullptr;
    Node *p = a.head;
    a.head = p->next;
    p->next = nullptr;
    return p;
}

void link2Lists(myList &a, myList &b){
    if (a.head == nullptr){
        a.head = b.head;
        a.tail = b.tail;
        return;
    }
    if (b.head == nullptr)
        return;
    a.tail->next = b.head;
    a.tail = b.tail;
    b.head = b.tail = nullptr;
}

void quickSortLinkedList(myList &a){
    if (a.head == nullptr)
        return;
    if (a.head == a.tail)
        return;

    Node *pivot = removeHead(a);

    myList left,right;
    creatList(left);
    creatList(right);

    while (a.head){
        if (a.head->info <= pivot->info){
            addTail(left,removeHead(a));
        }
        else{
            addTail(right,removeHead(a));
        }
    }

    quickSortLinkedList(left);
    quickSortLinkedList(right);

    addTail(left,pivot);
    link2Lists(left,right);
    a = left;
}

void reverseList(myList &a){
    if (a.head == nullptr)
        return;
    Node *p = a.head;
    while(p->next){
        int x = p->next->info;
        addHead(a,creatNode(x));
        removeAfter(a,p);
    }
}


void printRV(myList a){
    if (a.head == nullptr) return;
    Node* p = a.head;
    a.head = a.head->next;

    printRV(a);

    cout << p->info << " ";
}


void slsort(myList &a){
    if (a.head == nullptr) return;
    Node* p = a.head;
    while(p){
        Node* minn = p;
        Node* movee = p->next;
        while(movee){
            if (minn->info > movee->info)
                minn = movee;
            movee = movee->next;
        }
        swap(p->info,minn->info);
        p = p->next;
    }
}




int main(){
    myList a;
    creatList(a);
    addTail(a,creatNode(12));
    addTail(a,creatNode(3));
    addTail(a,creatNode(20));
    addTail(a,creatNode(5));
    addTail(a,creatNode(4));
    addTail(a,creatNode(7));
    printList(a);
    slsort(a);
    cout << endl;
    printList(a);
    return 0;
}
