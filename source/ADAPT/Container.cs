﻿/*******************************************************************************
  * Copyright (C) 2015 AgGateway and ADAPT Contributors
  * Copyright (C) 2015 Deere and Company
  * All rights reserved. This program and the accompanying materials
  * are made available under the terms of the Eclipse Public License v1.0
  * which accompanies this distribution, and is available at
  * http://www.eclipse.org/legal/epl-v10.html <http://www.eclipse.org/legal/epl-v10.html> 
  *
  * Contributors:
  *    Justin Sliekers - creating class
  *******************************************************************************/

using System.Collections.Generic;

namespace AgGateway.ADAPT.ApplicationDataModel
{
    public class Container
    {
        public Container()
        {
            Id = CompoundIdentifierFactory.Instance.Create();
        }

        public NumericRepresentation ProductAmount { get; set; }
        
        public NumericRepresentation Capacity { get; set; }

        public List<ContextItem>  ContextItems { get; set; }

        public string Description { get; set; }

        public CompoundIdentifier Id { get; private set; }
    }
}