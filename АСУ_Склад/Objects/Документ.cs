﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.АСУ_Склад
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Документ.
    /// </summary>
    // *** Start programmer edit section *** (Документ CustomAttributes)

    // *** End programmer edit section *** (Документ CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("ДокументE", new string[] {
            "Номер as \'Номер\'",
            "Дата_Заполнения as \'Дата_ заполнения\'"})]
    [View("ДокументL", new string[] {
            "Номер as \'Номер\'",
            "Дата_Заполнения as \'Дата_ заполнения\'"})]
    public class Документ : ICSSoft.STORMNET.DataObject
    {
        
        private int fНомер;
        
        private System.DateTime fДата_Заполнения = System.DateTime.Now;
        
        // *** Start programmer edit section *** (Документ CustomMembers)

        // *** End programmer edit section *** (Документ CustomMembers)

        
        /// <summary>
        /// Номер.
        /// </summary>
        // *** Start programmer edit section *** (Документ.Номер CustomAttributes)

        // *** End programmer edit section *** (Документ.Номер CustomAttributes)
        public virtual int Номер
        {
            get
            {
                // *** Start programmer edit section *** (Документ.Номер Get start)

                // *** End programmer edit section *** (Документ.Номер Get start)
                int result = this.fНомер;
                // *** Start programmer edit section *** (Документ.Номер Get end)

                // *** End programmer edit section *** (Документ.Номер Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Документ.Номер Set start)

                // *** End programmer edit section *** (Документ.Номер Set start)
                this.fНомер = value;
                // *** Start programmer edit section *** (Документ.Номер Set end)

                // *** End programmer edit section *** (Документ.Номер Set end)
            }
        }
        
        /// <summary>
        /// Дата_Заполнения.
        /// </summary>
        // *** Start programmer edit section *** (Документ.Дата_Заполнения CustomAttributes)

        // *** End programmer edit section *** (Документ.Дата_Заполнения CustomAttributes)
        public virtual System.DateTime Дата_Заполнения
        {
            get
            {
                // *** Start programmer edit section *** (Документ.Дата_Заполнения Get start)

                // *** End programmer edit section *** (Документ.Дата_Заполнения Get start)
                System.DateTime result = this.fДата_Заполнения;
                // *** Start programmer edit section *** (Документ.Дата_Заполнения Get end)

                // *** End programmer edit section *** (Документ.Дата_Заполнения Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Документ.Дата_Заполнения Set start)

                // *** End programmer edit section *** (Документ.Дата_Заполнения Set start)
                this.fДата_Заполнения = value;
                // *** Start programmer edit section *** (Документ.Дата_Заполнения Set end)

                // *** End programmer edit section *** (Документ.Дата_Заполнения Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "ДокументE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ДокументE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ДокументE", typeof(IIS.АСУ_Склад.Документ));
                }
            }
            
            /// <summary>
            /// "ДокументL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ДокументL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ДокументL", typeof(IIS.АСУ_Склад.Документ));
                }
            }
        }
    }
}
