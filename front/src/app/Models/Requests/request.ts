import { Citizens } from '../Citizen/citizens';

export class Request {
    id:number;
    orgId:number;
    lat:number;
    long:number;
    dateTime:Date;
    response:Boolean;
    citId:number;
    userId:number;
    title:string;
    message:string;
    photo:string;
    cit:Citizens;
}
