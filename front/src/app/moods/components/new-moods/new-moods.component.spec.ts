import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NewMoodsComponent } from './new-moods.component';

describe('NewMoodsComponent', () => {
  let component: NewMoodsComponent;
  let fixture: ComponentFixture<NewMoodsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [NewMoodsComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(NewMoodsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
