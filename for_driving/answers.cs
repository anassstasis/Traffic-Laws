//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace for_driving
{
    using System;
    using System.Collections.Generic;
    
    public partial class answers
    {
        public int id_answer { get; set; }
        public Nullable<int> question_id { get; set; }
        public string answer_text { get; set; }
        public Nullable<int> is_correct { get; set; }
    
        public virtual questions questions { get; set; }
    }
}