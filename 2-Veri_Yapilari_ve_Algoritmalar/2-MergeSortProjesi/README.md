# MergeSortProjesi

Patika.Dev - Marge Sort Projesi reposu

Dizi;

> [16, 21, 11, 8, 12, 22] 

>## Yukarıdaki dizinin sort türüne göre aşamalarını yazınız.

```
Dizi;              [16, 21, 11, 8, 12, 22] 
                    ----------  ---------
                        /            \
1.Adım;       [16, 21, 11]        [8, 12, 22]
                /  \     \          /   \    \
2.Adım;      [16]  [21]  [11]     [8]  [12]  [22]  
                \  /      /         \   /     /
3.Adım;       [16, 21]  [11]     [8, 12]  [22]
                   \     /          \      /
4.Adım;         [11, 16, 21]      [8, 12, 22]
                       \             /
Sonuç;             [8, 11, 12, 16, 21, 22]
```

>## Big-O gösterimini yazınız.

```
                                               _
3.Adım;       [16, 21]  [11]     [8, 12]  [22]  |
                   \     /          \      /    |- n
4.Adım;         [11, 16, 21]      [8, 12, 22]  _|
```

Ve;

```
Dizi;              [16, 21, 11, 8, 12, 22] 
                        /            \
1.Adım;        [16, 21, 11]        [8, 12, 22]
            |___________________________________|
                            2^x = n
                             =logn
```

Sonuç;

```
Big-O ;
    n*logn = O(nlogn)
```

 # License 

 [MIT](https://github.com/bhtyrbyr/kodluyoruzilkrepo/blob/main/LICENSE)