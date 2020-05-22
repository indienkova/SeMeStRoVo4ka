import {Post} from "./post";
import {User} from "./User";

export interface Category {
  name:string;
  posts:Post[];
  user:User;
}
