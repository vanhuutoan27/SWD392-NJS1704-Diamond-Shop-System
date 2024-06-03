export interface Province {
  id: string;
  full_name: string;
}

export interface District {
  id: string;
  full_name: string;
}

export interface Ward {
  id: string;
  full_name: string;
}

export interface FormData {
  email: string;
  fullName: string;
  phoneNumber: string;
  address: string;
  province: string;
  district: string;
  ward: string;
}

export interface InformationFormProps {
  formData: FormData;
  setFormData: (data: FormData) => void;
  provinces: Province[];
  setProvinces: (provinces: Province[]) => void;
  districts: District[];
  setDistricts: (districts: District[]) => void;
  wards: Ward[];
  setWards: (wards: Ward[]) => void;
}

export interface ShippingFormProps {
  formData: FormData;
  provinces: Province[];
  districts: District[];
  wards: Ward[];
}
