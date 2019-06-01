import { Photo } from "./Photo";

export interface Product{
    productId:number;
    productName:string;
    details:string;
    unitPrice:number;
    isActive:boolean;

    photos?:Photo[];
}