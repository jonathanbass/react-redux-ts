interface IAddress {
    houseNumber: number;
    address1: string;
    address2: string;
    postCode: string;
    telephone: string;
}

export interface IStudent {
    id: number;
    name: string;
    role?: number;
    address?: IAddress;
}

export interface IStudents {
    students: IStudent[];
}
