//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectSC_Type3
{
    using System;
    using System.Collections.Generic;
    
    public partial class Zakaz
    {
        public int id_zakaz { get; set; }
        public int id_user { get; set; }
        public int id_prepod { get; set; }
        public int id_kurs { get; set; }
        public int lstime { get; set; }
        public System.DateTime DateZ { get; set; }
    
        public virtual Kurs Kurs { get; set; }
        public virtual Prepod Prepod { get; set; }
        public virtual TimeSC TimeSC { get; set; }
        public virtual Users Users { get; set; }
    }
}
