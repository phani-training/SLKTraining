import { Component } from '@angular/core';

@Component({
  selector: 'app-footer',
  templateUrl: './footer.component.html',
  styleUrls: ['./footer.component.css']
})
export class FooterComponent {
  copyrights: string = "All Rights Reserved, Owned by SLK Training";
  year : number = new Date().getFullYear();
}
