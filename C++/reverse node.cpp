/*###Begin banned keyword - each of the following line if appear in code will raise error. regex supported
define
include
using
std
###End banned keyword*/

#include <iostream>
#include <limits>
using namespace std;

class SinglyLinkedListNode {
    public:
        int data;
        SinglyLinkedListNode *next;

        SinglyLinkedListNode(int node_data) {
            this->data = node_data;
            this->next = nullptr;
        }
};

class SinglyLinkedList {
    public:
        SinglyLinkedListNode *head;
        SinglyLinkedListNode *tail;

        SinglyLinkedList() {
            this->head = nullptr;
            this->tail = nullptr;
        }

};




// Complete the insertSortedLinkedList function below.

/*
 * For your reference:
 *
 * SinglyLinkedListNode {
 *     int data;
 *     SinglyLinkedListNode* next;
 * };
 *
 */

//###INSERT CODE HERE -
void insert_node(SinglyLinkedList* llist,int llist_item){
    SinglyLinkedListNode* a = new SinglyLinkedListNode(llist_item);
    if (llist->head == nullptr)
        llist->head = a;
    else
        llist->tail->next = a;
    llist->tail = a;

}
void reverseLinkedList(SinglyLinkedList* llist){
    int arr[1000];
    SinglyLinkedListNode* a = llist->head;
    int i;
    for (i=0 ; a ; ++i){
        arr[i] = a->data;
        a = a->next;
    }
    a = llist->head;
    while (a){
        a->data = arr[--i];
        a = a->next;
    }

}
void printLinkedList(SinglyLinkedList* llist){
    SinglyLinkedList* a = llist;
    while (a->head){
        cout << a->head->data << " ";
        a->head = a->head->next;
    }
}

int main()
{
    SinglyLinkedList* llist = new SinglyLinkedList();
    int llist_count;


    cin >> llist_count;

    for (int i = 0; i < llist_count; i++) {
        int llist_item;
        cin >> llist_item;

        insert_node(llist,llist_item);
    }


    reverseLinkedList(llist);
    printLinkedList(llist);

    return 0;
}
