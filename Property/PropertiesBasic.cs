/** 
  * 原始方法中，要用 methods 取用 field (資料) 過程相當繁瑣
  * 假如還有另外五個 fields，那每個都得寫 methods (就要寫10個)
  * 為解決這個問題而有了 -- property
  */

namespace PropertiesBasic
{
    public class Person
    {

      private DateTime _birthdate;

      // before: 較為繁瑣的 methods 取用 field (資料) 過程
      // public void SetBirthdate(DateTime value)
      // {
      //    this._birthdate = value;
      // }

      // public DateTime GetBirthdate()
      // {
      //     return _birthdate;
      // }

      // after: 使用 property 的寫法可以簡化以上寫法
      public DateTime Birthdate //Pascal Case
      {
          get { return _birthdate; }
          set { _birthdate = value; }
      }

  }
}