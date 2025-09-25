## 存取修飾詞 (Access Modifiers)

| 修飾詞                  | 可搭配對象                                                   | 說明                |
| -------------------- | ------------------------------------------------------- | ----------------- |
| `public`             | class, struct, enum, interface, field, property, method | 對外完全公開            |
| `internal`           | class, struct, enum, interface, field, property, method | 只在同一 assembly 可見  |
| `protected`          | class, field, property, method                          | 只有子類別可見           |
| `private`            | class, struct, field, property, method                  | 只有自身可見            |
| `protected internal` | class, field, property, method                          | 子類別或同 assembly 可見 |
| `private protected`  | class, field, property, method                          | 子類別且同 assembly 可見 |
