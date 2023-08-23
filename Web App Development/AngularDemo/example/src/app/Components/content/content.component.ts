import { Component } from '@angular/core';

@Component({
  selector: 'app-content',
  templateUrl: './content.component.html',
  styleUrls: ['./content.component.css']
})
export class ContentComponent {
  //members of our component
  value1 : number = 123;
  value2 : number = 234;
  result : number = this.value1 + this.value2;

  onClick = () =>{
    alert("Welcome to Angular UI Programming")
  }
}
