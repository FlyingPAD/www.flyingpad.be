import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RightColumnListComponent } from './right-column-list.component';

describe('RightColumnListComponent', () => {
  let component: RightColumnListComponent;
  let fixture: ComponentFixture<RightColumnListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [RightColumnListComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(RightColumnListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
