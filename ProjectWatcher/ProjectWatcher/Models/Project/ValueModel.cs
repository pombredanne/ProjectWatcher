﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL.Interface;

namespace ProjectWatcher.Models.Project
{
    public class ValueModel
    {
        private IValue entity;

        public ValueModel(IValue entity)
        {
            this.entity = entity;
        }


        public String SystemName
        {
            get 
            {
                return entity.SystemName;
            }
            set 
            {
                entity.SystemName = value;
            }
        }

        public String Name
        {
            get 
            {
                return entity.GetProperty().DisplayName;
            }
            set
            {
                entity.GetProperty().DisplayName = value;
            }
        }

        public String Value
        {
            get
            {
                return entity.GetValue().ToString();
            }
        }

        public Int32 ProjectId
        {
            get
            {
                return entity.ProjectId;
            }
            set
            {
                entity.ProjectId = value;
            }
        }

        public Int32 Id
        {
            get
            {
                return entity.Id;
            }
            set
            {
                entity.Id = value;
            }
        }

        public Boolean Visible
        {
            get
            {
                return entity.Visible;
            }
            set
            {
                entity.Visible = value;
            }
        }

        public Boolean IsImportant
        {
            get
            {
                return entity.Important;
            }
            set
            {
                entity.Important = value;
            }
        }

        public String Author
        {
            get
            {
                return entity.Author;
            }
            set
            {
                entity.Author = value;
            }
        }

        public DateTime Time
        {
            get
            {
                return entity.Time;
            }
            set
            {
                entity.Time = value;
            }
        }

        public IProperty Property
        {
            get 
            {
                return entity.GetProperty();
            }
        }
    }
}